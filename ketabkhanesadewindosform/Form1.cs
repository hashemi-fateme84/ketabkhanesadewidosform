using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ketabkhanesadewindosform
{

   
    

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Book x = new Book( "بوف کور","صادق هدایت","978-964-448-008-5","1385");
            Book y = new Book("ملت عشق", "ارسلان فصیحی", "978-600-8132-41-3", "1395");
            Book u = new Book("بی کتاب", "محمدرضاشرفی خبوشان", "878-600-175-631-9", "1395");
            MessageBox.Show(x.print() + "\n" + y.print() + "\n" + u.print()); 
        }
        public class Book
        {


            /// peroperti/////


            private string Title
            {
                get;
                set;
            }
            private string Author
            {
                get;
                set;
            }
            private string Isbn
            {
                get;
                set;
            }
            private string YrearOfPblication
            {
                get;
                set;
            }

            ////////constractor////
            public Book(string Title, string Author, string Isbn, string YrearOfPblication)
            {
                this.Title = Title;
                this.Author = Author;
                this.Isbn = Isbn;
                this.YrearOfPblication = YrearOfPblication;
            }
            //////metood//////
            public string print()
            {
                string n = Title + ",   " + Author + ",   " + Isbn + ",  " + YrearOfPblication;
                return n;
             
            }

        }
        public class Member
        {
            /////peroperti/////
            private string Name
            {
                get;
                set;
            }
            private string MemberId
            {
                get;
                set;
            }
            private string Phone
            {
                get;
                set;
            }

            ////////constractor////
            public Member(string Name, string MemberId, string Phone)
            {
                this.Name = Name;
                this.MemberId = MemberId;
                this.Phone = Phone;
            }
            ////metood///
            public string printmemberinfo()
            {
                string m = Name + ",   " + MemberId + ",   " + Phone;
                return m;
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Member a = new Member("فاطی", "fatiii", "099100000");
            MessageBox.Show(a.printmemberinfo());
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
