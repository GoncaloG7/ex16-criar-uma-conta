﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ex16_criar_uma_conta.FormConta;

namespace ex16_criar_uma_conta.Classes
{
    internal class fechar
    {
        public static void fecharForm()
        {
            foreach (Form frm in Application.OpenForms)
            {
                frm.Close();
            }
        }

        public static void voltarForm1(Form thisvar)
        {
            Form1 form1 = new Form1();
            form1.Show();
            thisvar.Hide();
        }

        public static void voltarForm2(Form thisvar)
        {
            Form2 form2 = new Form2();
            form2.Show();
            thisvar.Hide();
        }

        public static void abrirForm3(Form thisvar)
        {
            Form3 form3 = new Form3();
            form3.Show();
            thisvar.Hide();
        }
    }
}
