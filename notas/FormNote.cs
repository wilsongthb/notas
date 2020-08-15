using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Configuration;

namespace notas
{
  public partial class FormNote : Form
  {
    const int ESCAPE_KEY = 27;
    const int ENTER_KEY = 13;
    const int TAB_KEY = 9;
    const string HELP_TEXT = @"
Escribe el nombre de la nota 
y presiona <Enter> para empezar 
a editar, presiona <Esc> para
volver al nombre.

Los cambios se guardan luego
de presionar <Esc> o al cerrar
el programa.
";
    const string HELP_COMMAND = "?";

    string CUSTOM_TAB = null;
    string NOTES_DIRECTORY = null;
    List<FileMember> files = null;

    public FormNote()
    {
      this.CUSTOM_TAB = ConfigurationManager.AppSettings["CUSTOM_TAB"] ?? "\t";
      this.NOTES_DIRECTORY = ConfigurationManager.AppSettings["NOTES_DIRECTORY"] ?? @".\notes\";

      InitializeComponent();
    }

    private void scanDirectory()
    {
      this.checkDirectoryNotesExists();
      this.files = Array.ConvertAll(System.IO.Directory.GetFiles(NOTES_DIRECTORY), x => new FileMember(NOTES_DIRECTORY, x)).ToList();
    }

    private void txtRichMain_KeyUp(object sender, KeyEventArgs e)
    {
      if (e.KeyCode.GetHashCode() == ESCAPE_KEY)
      {
        this.focusToTxtBoxMain();
      }
    }

    private void focusToTxtBoxMain(bool saveChanges = true)
    {
      if (saveChanges) { this.writeChanges(); }
      this.txtBoxMain.Focus();
      this.txtBoxMain.Text = "";
    }

    private void writeChanges()
    {
      if (this.txtBoxMain.Text.Trim() != "" && this.txtRichMain.Text.Trim() != "")
      {
        System.IO.File.WriteAllText(NOTES_DIRECTORY + this.txtBoxMain.Text, this.txtRichMain.Text);
        this.printToLog("Cambios guardados: " + this.txtBoxMain.Text);
      }
    }

    private void printToLog(string message)
    {
      //this.txtRchLog.Text += "\n" + message;
      this.txtRchLog.Text = DateTime.Now + ": " + message;
    }

    private void checkDirectoryNotesExists()
    {
      System.IO.Directory.CreateDirectory(NOTES_DIRECTORY);
    }

    private void loadFile(string fileName)
    {
      this.checkDirectoryNotesExists();
      if (System.IO.File.Exists(NOTES_DIRECTORY + fileName))
      {
        this.txtRichMain.Text = System.IO.File
            .ReadAllText(NOTES_DIRECTORY + fileName);
      }
      else
      {
        this.printToLog("El archivo no existe");
        this.txtRichMain.Text = "";
      }
      this.txtRichMain.Focus();
      this.txtRichMain.SelectionStart = this.txtRichMain.Text.Length;
      this.txtRichMain.SelectionLength = 0;
    }

    private void FormNote_KeyUp(object sender, KeyEventArgs e)
    {
      //
    }

    private void txtBoxMain_Enter(object sender, EventArgs e)
    {
      this.addFilesToTxtBoxMain();
    }

    private void addFilesToTxtBoxMain()
    {
      this.scanDirectory();
      AutoCompleteStringCollection suggests = new AutoCompleteStringCollection();
      foreach (FileMember it in this.files)
      {
        suggests.Add(it.fileName());
      }
      this.txtBoxMain.AutoCompleteCustomSource = suggests;
    }

    private string cleanToFileName(string fileName)
    {
      return Regex.Replace(fileName, @"[^a-zA-Z0-9\.\s-_]+", "");
    }

    private void txtBoxMain_KeyUp(object sender, KeyEventArgs e)
    {
      if (e.KeyCode.GetHashCode() == ENTER_KEY)
      {
        if (this.txtBoxMain.Text == HELP_COMMAND)
        {
          this.showHelpText();
        }
        else
        {
          this.txtBoxMain.Text = this.cleanToFileName(this.txtBoxMain.Text);
          this.loadFile(this.txtBoxMain.Text);
        }
      }
      else if (e.KeyCode.GetHashCode() == ESCAPE_KEY)
      {
        this.focusToTxtBoxMain(false);
      }
    }

    private void showHelpText()
    {
      this.txtRichMain.Text = HELP_TEXT;
    }

    private int currentKeyCode = 0;
    private void txtRichMain_KeyDown(object sender, KeyEventArgs e)
    {
      this.currentKeyCode = e.KeyCode.GetHashCode();
    }

    private void txtRichMain_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (this.currentKeyCode == TAB_KEY)
      {
        e.Handled = true;
        int currentPosition = this.txtRichMain.SelectionStart;
        this.txtRichMain.Text = this.txtRichMain.Text.Insert(currentPosition, CUSTOM_TAB);
        this.txtRichMain.SelectionStart = currentPosition + CUSTOM_TAB.Length;
      }
    }

    private void FormNote_FormClosing(object sender, FormClosingEventArgs e)
    {
      this.writeChanges();
    }

    private void txtBoxMain_KeyPress(object sender, KeyPressEventArgs e)
    {
      //
    }
  }
}
