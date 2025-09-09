using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabExer03
{
    class StudentInformationClass
    {
        public string SetFullName { get; set; }
        public string SetStudentNo { get; set; }
        public string SetProgram { get; set; }
        public string SetGender { get; set; }
        public string SetContactNo { get; set; }
        public int SetAge { get; set; }

       
        
            public int ConvertToAge(string ageText)
        {
            try
            {
                if (!string.IsNullOrEmpty(ageText))
                {
                    return int.Parse(ageText);  // kung valid, ibalik value
                }
                else
                {
                    // Manual exception kapag walang laman
                    throw new ArgumentNullException("Age field cannot be empty.");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid age format. Please enter a number only.");
                return 0;
            }
            catch (ArgumentNullException ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }
            finally
            {
                Console.WriteLine("ConvertToAge() finished.");
            }



        }
        public string ConvertToStudentNo(string studentNo)
        {
            try
            {
                if (!string.IsNullOrEmpty(studentNo))
                {
                    return studentNo; // valid input
                }
                else
                {
                    throw new ArgumentNullException("Student Number cannot be empty.");
                }
            }
            catch (ArgumentNullException ex)
            {
                MessageBox.Show(ex.Message);
                return string.Empty;
            }
            finally
            {
                Console.WriteLine("ConvertToStudentNo() finished.");
            }
        }
        public string ConvertToContactNo(string contactNo)
        {
            try
            {
                if (!string.IsNullOrEmpty(contactNo))
                {
                    if (contactNo.All(char.IsDigit))
                        return contactNo;
                    else
                        throw new FormatException("Contact number must contain digits only.");
                }
                else
                {
                    throw new ArgumentNullException("Contact Number cannot be empty.");
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message);
                return string.Empty;
            }
            catch (ArgumentNullException ex)
            {
                MessageBox.Show(ex.Message);
                return string.Empty;
            }
            finally
            {
                Console.WriteLine("ConvertToContactNo() finished.");
            }
        }
    }
}
