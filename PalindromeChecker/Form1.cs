using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PalindromeChecker
{
    
    public partial class PalindromeChecker : Form
    {
        private String startStr;
        private String revStr;
        public PalindromeChecker()
        {
            InitializeComponent();
        }

        private String reverseString(String s)
        {
            if (s == null) return null;

            char[] a = s.ToCharArray();
            Array.Reverse(a);
            return new string(a);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            startStr = strBox.Text;
            revStr = reverseString(startStr);
            
            if (revStr.ToUpper()==startStr.ToUpper())
            {
                MessageBox.Show("The reverse of the string is " + revStr.ToLower()+".\n"+startStr+" is a palindrome!","Result");
            }
            else
            {
                MessageBox.Show("The reverse of the string is " + revStr.ToLower() + ".\n" + startStr + " is not a palindrome.","Result");
            }
        }
    }
}
