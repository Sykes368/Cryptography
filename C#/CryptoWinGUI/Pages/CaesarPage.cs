﻿using System;
using System.Windows.Forms;
using CryptoLib;

namespace CryptoWinGUI
{
    public partial class CaesarPage : Form
    {
        public CaesarPage()
        {
            InitializeComponent();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void CaesarEncrypt_Click(object sender, EventArgs e)
        {
            CaesarOutput.Text = Caesar.Encrypt(CaesarInput.Text, Convert.ToInt32(shiftNumber.Value));
        }

        private void CaesarDecrypt_Click(object sender, EventArgs e)
        {
            CaesarOutput.Text = Caesar.Decrypt(CaesarInput.Text, Convert.ToInt32(shiftNumber.Value));
        }
    }
}