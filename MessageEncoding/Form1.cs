using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MessageEncoding
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDecode_Click(object sender, EventArgs e)
        {
            var sourceText = txtSource.Text;
            txtResult.Text = Decode(sourceText);
        }

        public string Decode(string source)
        {
            var result = "";
            
            // decode the source
            var chs = new char[1]{' '};
            var words = source.Split(chs);
            for (int i = 0; i < words.Length; i++)
            {
                var newWord = RemoveFirstAndLastCh(words[i]);
                result += newWord + " ";
            }

            return result;
        }

        public string RemoveFirstAndLastCh(string word)
        {
            // xhelloy
            var result = "";
            for (var i = 1; i < word.Length -1; i++)
            {
                result += (word.Substring(i, 1));
            }
            return result;
        }

        private void btnEncode_Click(object sender, EventArgs e)
        {
            var sourceText = txtSource.Text;
            txtResult.Text = Encode(sourceText);
        }
        

        private string Encode(string source)
        {
            if (source == "") return "";
            var result = "";

            // encode the source
            var chs = new char[1] { ' ' };
            var words = source.Split(chs);
            for (int i = 0; i < words.Length; i++)
            {
                var startCh = Guid.NewGuid().ToString().Substring(0, 1);  //Guid choose random char..
                var endCh = Guid.NewGuid().ToString().Substring(0,1);
                
                result += startCh + words[i] + endCh + " ";
            }

            return result;

        }
    
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtSource_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtResult_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

    
    }
}
