﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassicPacketScout
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void frmEncoder_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void btnToB64_Click(object sender, EventArgs e)
        {
            try
            {
                string value = Base64Encoding.EncodeInt32(int.Parse(txtToB64.Text), 2);
                txtFromB64.Text = value;

                if (txtToB64.Text != Base64Encoding.DecodeInt32(value).ToString())
                {
                    txtFromB64.Text = "ERROR";
                }
            }
            catch (Exception ex)
            {
                txtFromB64.Text = "ERROR";
            }
        }

        private void btnFromB64_Click(object sender, EventArgs e)
        {
            try
            {
                try
                {
                    int value = Base64Encoding.DecodeInt32(txtFromB64.Text);
                    txtToB64.Text = value + "";

                    if (txtFromB64.Text != Base64Encoding.EncodeInt32(value, 2).ToString())
                    {
                        txtToB64.Text = "ERROR";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            catch (Exception ex)
            {
                txtToB64.Text = "ERROR";
            }
        }

        private void btnToVL64_Click(object sender, EventArgs e)
        {
            try
            {
                string value = WireEncoding.EncodeInt32(int.Parse(txtToVL64.Text));
                txtFromVL64.Text = value;

                int len;
                if (WireEncoding.DecodeInt32(value, out len).ToString() != txtToVL64.Text)
                {
                    txtFromVL64.Text = "ERROR";
                }
            }
            catch (Exception ex)
            {
                txtFromVL64.Text = "ERROR";
            }
        }

        private void btnFromVL64_Click(object sender, EventArgs e)
        {
            try
            {
                int i;
                int value = WireEncoding.DecodeInt32(txtFromVL64.Text, out i);
                txtToVL64.Text = value + "";

                if (WireEncoding.EncodeInt32(value).ToString() != txtFromVL64.Text)
                {
                    txtToVL64.Text = "ERROR";
                }
            }
            catch (Exception ex)
            {
                txtToVL64.Text = "ERROR";
            }
        }

        private void btnDecode_Click(object sender, EventArgs e)
        {
            txtDecodeOutput.Text = "";
            lblDecoded.Text = string.Format("Integers decoded: {0}", 0);

            string leftToDecode = txtVL64.Text;

            int decoded = 0;
            while (leftToDecode.Length > 0)
            {
                int length;
                int value = 0;

                try
                {
                    value = WireEncoding.DecodeInt32(leftToDecode, out length);
                }
                catch
                {
                    length = 0;
                }

                bool raiseError = false;

                if (length == 0)
                {
                    raiseError = true;
                } 
                else if (leftToDecode.Substring(0, length).ToString() != WireEncoding.EncodeInt32(value)) 
                {
                    raiseError = true;
                }

                if (!raiseError)
                {

                    decoded++;
                    txtDecodeOutput.Text += leftToDecode.Substring(0, length) + " = " + value + Environment.NewLine;
                    lblDecoded.Text = string.Format("Integers decoded: {0}", decoded);
                }
                else
                {
                    length = leftToDecode.Length;
                    txtDecodeOutput.Text += leftToDecode.Substring(0, length) + " = ERROR" + Environment.NewLine;
                }

                leftToDecode = leftToDecode.Substring(length);
            }
        }
    }
}
