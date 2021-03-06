﻿using System;
using System.Windows.Forms;
using CryptoLib;

namespace CryptoWinGUI
{
    public partial class DevPage : Form
    {
        public DevPage()
        {
            InitializeComponent();
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AffineEncrypt_Click(object sender, EventArgs e)
        {
            try
            {
                AffineOutput.Text = Affine.Encrypt(AffineInput.Text, Convert.ToInt32(AffineA.Text), Convert.ToInt32(AffineB.Value));
            }
            catch
            {
                AffineOutput.Text = "Error: You must select a value for 'a'";
            }
        }

        private void AffineDecrypt_Click(object sender, EventArgs e)
        {
            try
            {
                AffineOutput.Text = Affine.Decrypt(AffineInput.Text, Convert.ToInt32(AffineA.Text), Convert.ToInt32(AffineB.Value));
            }
            catch
            {
                AffineOutput.Text = "Error: You must select a value for 'a'";
            }
        }

        private void RailFenceEncrypt_Click(object sender, EventArgs e)
        {
            RailFenceOutput.Text = RailFence.Encrypt(RailFenceInput.Text, Convert.ToInt32(Rails.Value));
        }

        private void RailFenceDecrypt_Click(object sender, EventArgs e)
        {
            RailFenceOutput.Text = RailFence.Decrypt(RailFenceInput.Text, Convert.ToInt32(Rails.Value));
        }

        private void VigenereEncrypt_Click(object sender, EventArgs e)
        {
            VigenereOutput.Text = Vigenere.Encrypt(VigenereInput.Text, VigenereKeyword.Text);
        }

        private void VigenereDecrypt_Click(object sender, EventArgs e)
        {
            VigenereOutput.Text = Vigenere.Decrypt(VigenereInput.Text, VigenereKeyword.Text);
        }

        private void PlayfairEncrypt_Click(object sender, EventArgs e)
        {
            PlayfairOutput.Text = Playfair.Encrypt(PlayfairInput.Text, PlayfairKeyword.Text);
        }

        private void PlayfairDecrypt_Click(object sender, EventArgs e)
        {
            PlayfairOutput.Text = Playfair.Decrypt(PlayfairInput.Text, PlayfairKeyword.Text);
        }
    }
}