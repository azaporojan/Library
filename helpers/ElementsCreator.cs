using Library.dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library.helpers
{
    public class ElementsCreator<T> where T : Control
    {
        private List<Panel> displayedPannels;
        private Dictionary<String, Book> displayedBooks;
        private T parentContainer;
        private Panel toolsPannel = new Panel();
        private Dictionary<String, Book> selectedBooks = new Dictionary<String, Book>();
        public ElementsCreator(T parentContainer)
        {
            this.parentContainer = parentContainer;
        }

        public List<Panel> BooksToDisplay { get => displayedPannels; set => displayedPannels = value; }
        public List<Panel> DisplayedPannels { get => displayedPannels; set => displayedPannels = value; }
        public Dictionary<string, Book> DisplayedBooks { get => displayedBooks; set => displayedBooks = value; }

        public void displayBooks()
        {
            if (displayedPannels.Count > 0)
                foreach (Panel book in displayedPannels)
                {
                    this.parentContainer.Controls.Add(book);
                }
        }

        public void removeBooks()
        {
            if (displayedPannels != null)
            {
                foreach (Panel book in displayedPannels)
                {
                    this.parentContainer.Controls.Remove(book);
                }
                displayedPannels = null;
                displayedBooks = null;
            }
        }

        public void createPanels(List<Book> listOfBooks)
        {
            if (this.displayedPannels != null)
            {
                if (this.displayedPannels.Count > 0)
                {
                    this.removeBooks();
                }
            }
            this.displayedPannels = new List<Panel>();
            this.displayedBooks = new Dictionary<string, Book>();
            foreach (Book book in listOfBooks)
            {
                displayedBooks.Add(book.IdBook.ToString(), book);
                Panel bookPanel = new Panel();
                PictureBox bookImage = new PictureBox();
                Label bookInfo = new Label();
                Label bookName = new Label();
                Label bookAuthor = new Label();
                Label yearPub = new Label();
                Label condition = new Label();
                Button bookButton = new Button();


                bookPanel.SuspendLayout();
                ((System.ComponentModel.ISupportInitialize)(bookImage)).BeginInit();
                // 
                // bookPanel
                // 
                bookPanel.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
                bookPanel.Controls.Add(bookButton);
                bookPanel.Controls.Add(bookInfo);
                bookPanel.Controls.Add(bookImage);

                if (displayedPannels.Count > 0)
                {
                    Panel previosPanel = displayedPannels[displayedPannels.Count - 1];
                    if (previosPanel.Location.X + previosPanel.Width + 30 + previosPanel.Width >= parentContainer.Width)
                    {
                        bookPanel.Location = new System.Drawing.Point(displayedPannels[0].Location.X, previosPanel.Location.Y + previosPanel.Height + 30);
                        parentContainer.Height = parentContainer.Height + 30;
                    }
                    else
                        bookPanel.Location = new System.Drawing.Point(previosPanel.Location.X + previosPanel.Width + 30, previosPanel.Location.Y);
                }
                else bookPanel.Location = new System.Drawing.Point(parentContainer.Width / 100 * 15, 30);

                bookPanel.Name = book.IdBook.ToString();
                bookPanel.Size = new System.Drawing.Size(284, 461);
                bookPanel.TabIndex = 2;
                // 
                // bookImage
                // 
                bookImage.Image = Adapter.decodeImage(book.ImageEncoded);
                bookImage.Location = new System.Drawing.Point(13, 15);
                bookImage.Name = "bookImage";
                bookImage.Size = new System.Drawing.Size(255, 250);
                bookImage.SizeMode = PictureBoxSizeMode.StretchImage;
                bookImage.TabIndex = 2;
                bookImage.TabStop = false;
                // 
                // bookInfo - label
                // 
                bookInfo.AutoSize = true;
                bookInfo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                bookInfo.Location = new System.Drawing.Point(10, 285);
                bookInfo.Name = "label1";
                bookInfo.Size = new System.Drawing.Size(61, 24);
                bookInfo.TabIndex = 3;
                bookInfo.Text = book.getString();
                // 
                // bookButton
                // 
                bookButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
                bookButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                bookButton.Location = new System.Drawing.Point(217, 402);
                bookButton.Name = book.IdBook.ToString();
                bookButton.Size = new System.Drawing.Size(51, 51);
                bookButton.TabIndex = 4;
                bookButton.Text = isSelected(book) ? "✓" : " ";
                bookButton.UseVisualStyleBackColor = false;
                bookButton.Click += new EventHandler(this.bookButton_Click);
                bookPanel.ResumeLayout(false);
                bookPanel.PerformLayout();
                ((System.ComponentModel.ISupportInitialize)(bookImage)).EndInit();
                this.displayedPannels.Add(bookPanel);
                //form.Controls.Add(bookPanel);
            }
            parentContainer.ResumeLayout(false);
            parentContainer.PerformLayout();
        }
        private void bookButton_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if (button.Text != "✓")
            {
                button.Text = "✓";
                selectedBooks.Add(button.Name,displayedBooks[button.Name]);
            }
            else
            {
                button.Text = " ";
                selectedBooks.Remove(button.Name);
            }
        }

        private bool isSelected(Book book)
        {
           return selectedBooks.ContainsKey(book.IdBook.ToString());
        }

    }
}
