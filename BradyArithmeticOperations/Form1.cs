using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/***************************************************************
* Name        : Arithmetic Operations
* Author      : Kabrina Brady
* Created     : 9/7/2019
* Course      : CIS 169 - C#
* Version     : 1.0
* OS          : Windows 10
* Copyright   : This is my own original work
* Description : User types numbers into TextBoxes, then clicks Submit. The Submit button performs the calculations, and the result is displayed
*               Input:  Numbers user types into TextBoxes
*               Output: Answer to calculation
* Academic Honesty: I attest that this is my original work.
* I have not used unauthorized source code, either modified or unmodified. I have not given other fellow student(s) access to my program.         
***************************************************************/

namespace BradyArithmeticOperations
{

    public partial class arithmeticOperations : Form
    {
       
        public arithmeticOperations()
        {
            InitializeComponent();
        }

        //Exit button
        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            //Addition
            decimal additionInput; //to hold user input from txtAddition
            decimal additionInput2; //to hold user input from txtAddition2
            decimal sum; //to hold the answer
            additionInput = decimal.Parse(txtAddition.Text); //converts string into decimal
            additionInput2 = decimal.Parse(txtAddition2.Text); //converts string into decimal
            sum = additionInput + additionInput2; //calculation
            lblResult.Text = sum.ToString(); //converts decimal back into string to display in label
        }

        private void TextBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtAddition_TextChanged(object sender, EventArgs e)
        {

        }

        private void LblOutput_Click(object sender, EventArgs e)
        {

        }

        private void BtnSubmitSubtraction_Click(object sender, EventArgs e)
        {
            //Subtraction
            decimal subtractionInput; //to hold user input from txtSubtraction
            decimal subtractionInput2; //to hold user input from txtSubtraction2
            decimal difference; //to hold the answer
            subtractionInput = decimal.Parse(txtSubtraction.Text); //converts string into decimal
            subtractionInput2 = decimal.Parse(txtSubtraction2.Text); //converts string into decimal
            difference = subtractionInput - subtractionInput2; //calculation
            lblResult.Text = difference.ToString(); //converts decimal back into string to display in label
        }

        private void BtnMultiplicationSubmit_Click(object sender, EventArgs e)
        {
            //Multiplication
            decimal multiplicationInput; //to hold user input from txtMultiplication
            decimal multiplicationInput2; //to hold user input from txtMultiplication2
            decimal product; //to hold the answer
            multiplicationInput = decimal.Parse(txtMultiplication.Text); //converts string into decimal
            multiplicationInput2 = decimal.Parse(txtMultiplication2.Text); //converts string into decimal
            product = multiplicationInput * multiplicationInput2; //calculation
            lblResult.Text = product.ToString(); //converts decimal back into string to display in label
        }

        private void BtnDivisionSubmit_Click(object sender, EventArgs e)
        {
            //Division
            decimal divisionInput; //to hold user input from txtDivision
            decimal divisionInput2; //to hold user input from txtDivision2
            decimal quotient; //to hold the answer
            divisionInput = decimal.Parse(txtDivision.Text); //converts string into decimal
            divisionInput2 = decimal.Parse(txtDivision2.Text); //converts string into decimal
            quotient = divisionInput / divisionInput2; //calculation
            lblResult.Text = quotient.ToString(); //converts decimal back into string to display in label
        }

        private void BtnModulusSubmit_Click(object sender, EventArgs e)
        {
            //Modulus
            decimal modulusInput; //to hold user input from txtModulus
            decimal modulusInput2; //to hold user input from txtModulus2
            decimal modAnswer; //to hold the answer
            modulusInput = decimal.Parse(txtModulus.Text); //converts string into decimal
            modulusInput2 = decimal.Parse(txtModulus2.Text); //converts string into decimal
            modAnswer = modulusInput % modulusInput2; //calculation
            lblResult.Text = modAnswer.ToString(); //converts decimal back into string to display in label
        }

        private void BtnIncrementSubmit_Click(object sender, EventArgs e)
        {
            //Increment
            decimal incrementInput; //to hold user input from txtIncrement
            decimal incrementInput2; //to hold user input from txtIncrement2
            decimal incAnswer; //to hold the answer
            incrementInput = decimal.Parse(txtIncrement.Text); //converts string into decimal
            incAnswer = incrementInput += 1; //calculation
            lblResult.Text = incAnswer.ToString(); //converts decimal back into string to display in label
        }

        private void BtnDecrementSubmit_Click(object sender, EventArgs e)
        {
            //Decrement
            decimal decrementInput; //to hold user input from txtDecrement
            decimal decrementInput2; //to hold user input from txtDecrement2
            decimal decAnswer; //to hold the answer
            decrementInput = decimal.Parse(txtDecrement.Text); //converts string into decimal
            decAnswer = decrementInput -= 1; //calculation
            lblResult.Text = decAnswer.ToString(); //converts decimal back into string to display in label
        }
    }
}
