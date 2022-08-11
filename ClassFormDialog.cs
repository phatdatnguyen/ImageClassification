using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageClassification
{
    public partial class ClassFormDialog : Form
    {
        // Property
        public string ClassLabel { get { return classLabelTextBox.Text; } }

        // Constructors
        public ClassFormDialog()
        {
            InitializeComponent();
        }

        public ClassFormDialog(string classLabel)
        {
            InitializeComponent();

            classLabelTextBox.Text = classLabel;
        }
    }
}
