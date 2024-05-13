using Microsoft.Analytics.Interfaces;
using Microsoft.Analytics.Interfaces.Streaming;
using Microsoft.Analytics.Types.Sql;
using Microsoft.Analytics.UnitTest;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using calculator;

namespace Tests
{
    [TestClass]
    public class CalculatorTests
    {
        [TestMethod]
        public void TestButton1Click_Addition()
        {
            // Arrange
            Form1 form = new Form1();
            form.textBox1.Text = "2";
            form.textBox2.Text = "3";
            form.comboBox1.Text = "+";

            // Act
            form.button1_Click(null, null);

            // Assert
            Assert.AreEqual("5", form.textBox3.Text);
        }

        [TestMethod]
        public void TestButton1Click_DivisionByZero()
        {
            // Arrange
            Form1 form = new Form1();
            form.textBox1.Text = "4";
            form.textBox2.Text = "0";
            form.comboBox1.Text = "/";

            // Act
            form.button1_Click(null, null);

            // Assert
            Assert.AreEqual("∞", form.textBox3.Text);
        }
    }
}
