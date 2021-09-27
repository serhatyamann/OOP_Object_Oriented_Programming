using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Inheritance.Model.Base;
using Inheritance.Model.Derived;

namespace Inheritance
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Animals animal = new Animals();
            animal.Age = 2;
            animal.Height = 50;
            animal.Name = "Molly";
            MessageBox.Show($"Name: {animal.Name}\nAge: {animal.Age}\nHeight: {animal.Height}");

            Dog dog = new Dog();
            dog.Age = 1;
            dog.Height = 30;
            dog.Name = "Scooby";
            dog.Sounds = "Woof, woof!";
            MessageBox.Show($"Name: {dog.Name}\nAge: {dog.Age}\nHeight: {dog.Height}\nSound: {dog.Sounds}");

            Cat cat = new Cat();
            cat.Age = 3;
            cat.Height = 15;
            cat.Name = "Tom";
            cat.Sounds = "Meow, meow!";
            MessageBox.Show($"Name: {cat.Name}\nAge: {cat.Age}\nHeight: {cat.Height}\nSound: {cat.Sounds}");

        }
    }
}
