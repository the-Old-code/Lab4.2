using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace OOP_42
{
    public partial class Form_main : Form
    {
        Model model;

        public Form_main()
        {
            InitializeComponent();
            model = new Model();
            model.observer += new System.EventHandler(this.UpdateModel);
            load();
                      
        }
       
        public void save() 
        {
            File.WriteAllText("savedata.txt", "");
            StreamWriter writer = new StreamWriter("savedata.txt", true);
            writer.WriteLine("{0} {1}", model.getA(),model.getC());
            writer.Close();
        }

        public void load() 
        {
            model.SetA("savedata.txt");
            model.SetC("savedata.txt");
            model.SetB();
        }
        private void num_A_ValueChanged(object sender, EventArgs e)
        {
            model.SetA(Decimal.ToInt32(num_A.Value));
        }

        private void tb_A_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                model.SetA(Int32.Parse(tb_A.Text));
            }
        }
        private void track_A_Scroll(object sender, EventArgs e)
        {
            model.SetA(track_A.Value);
        }

        private void num_B_ValueChanged(object sender, EventArgs e)
        {
            model.SetB(Decimal.ToInt32(num_B.Value));
        }

        private void tb_B_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                model.SetB(Int32.Parse(tb_B.Text));
            }

        }

        private void track_B_Scroll(object sender, EventArgs e)
        {
            model.SetB(track_B.Value);
        }

        private void num_C_ValueChanged(object sender, EventArgs e)
        {
            model.SetC(Decimal.ToInt32(num_C.Value));
        }

        private void tb_C_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                model.SetC(Int32.Parse(tb_C.Text));
            }

        }

        private void track_C_Scroll(object sender, EventArgs e)
        {
            model.SetC(track_C.Value);
        }

        private void UpdateModel(object sender, EventArgs e)
        {
            tb_A.Text = model.getA().ToString();
            num_A.Value = model.getA();
            track_A.Value = model.getA();


            tb_B.Text = model.getB().ToString();
            num_B.Value = model.getB();
            track_B.Value = model.getB();


            tb_C.Text = model.getC().ToString();
            num_C.Value = model.getC();
            track_C.Value = model.getC();
        }

        private void Form_main_FormClosing(object sender, FormClosingEventArgs e)
        {
            save();
        }
    }
}

public class Model
{
    private int  max, min, A, B, C;
        
    public System.EventHandler observer;  
    public Model()
    {     
        max = 100;
        min = 0;
        A = 0;
        B = 50;
        C = 100;
    }
    public void SetA(int _value)
    {
        if (_value <= B && _value >= min)
            A = _value;
        observer.Invoke(this, null);
    }

    public void SetA(string path)
    {
        StreamReader streamReader = new StreamReader(path);
        string tmp = streamReader.ReadLine();
        string[] tmparr = tmp.Split(' ');
        A = Int32.Parse(tmparr[0]);
        streamReader.Close();
        observer.Invoke(this, null);
    }

    public void SetB(int _value)
    {
        if (_value <= C && _value >= A)
            B = _value;
        observer.Invoke(this, null);
    }

    public void SetB()
    {
        B = A + (C - A)/2;
        observer.Invoke(this, null);
    }

    public void SetC(int _value)
    {
        if (_value <= max && _value >= B)
            C = _value;
        observer.Invoke(this, null);
    }

    public void SetC(string path)
    {
        StreamReader streamReader = new StreamReader(path);
        string tmp = streamReader.ReadLine();
        string[] tmparr = tmp.Split(' ');
        C = Int32.Parse(tmparr[1]);
        streamReader.Close();
        observer.Invoke(this, null);
    }

    public int getA()
    {
        return A;
    }
    public int getB()
    {
        return B;
    }
    public int getC()
    {
        return C;
    }
}
