using MetroSuite;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium;
using System.Windows.Forms;

public partial class MainForm : MetroForm
{
    private UndetectedChromeDriver.UndetectedChromeDriver driver = UndetectedChromeDriver.UndetectedChromeDriver.Create(driverExecutablePath: Application.StartupPath + "\\chromedriver.exe", headless: true);

    public MainForm()
    {
        InitializeComponent();
        guna2ComboBox1.SelectedIndex = 0;
    }

    private void guna2ComboBox1_SelectedIndexChanged(object sender, System.EventArgs e)
    {
        guna2ComboBox2.Items.Clear();

        if (guna2ComboBox1.SelectedIndex == 0)
        {
            guna2ComboBox2.Items.Add("Steffan");
            guna2ComboBox2.Items.Add("Sara");
            guna2ComboBox2.Items.Add("Davis");
            guna2ComboBox2.Items.Add("Jane");
            guna2ComboBox2.Items.Add("Steffan");
            guna2ComboBox2.Items.Add("Eric");
            guna2ComboBox2.Items.Add("Michelle");
            guna2ComboBox2.Items.Add("Brandon");
            guna2ComboBox2.Items.Add("Ana (Child)");
        }
        else if (guna2ComboBox1.SelectedIndex == 1)
        {
            guna2ComboBox2.Items.Add("Oliver");
            guna2ComboBox2.Items.Add("Sonia");
            guna2ComboBox2.Items.Add("Ryan");
            guna2ComboBox2.Items.Add("Libby");
            guna2ComboBox2.Items.Add("Brian");
            guna2ComboBox2.Items.Add("Maisie (Child)");
        }
        else if (guna2ComboBox1.SelectedIndex == 2)
        {
            guna2ComboBox2.Items.Add("William");
            guna2ComboBox2.Items.Add("Natasha");
            guna2ComboBox2.Items.Add("Russell");
            guna2ComboBox2.Items.Add("Nicole");
        }
        else if (guna2ComboBox1.SelectedIndex == 3)
        {
            guna2ComboBox2.Items.Add("Neerja");
            guna2ComboBox2.Items.Add("Prabhat");
            guna2ComboBox2.Items.Add("Raveena");
            guna2ComboBox2.Items.Add("Aditi");
        }
        else if (guna2ComboBox1.SelectedIndex == 4)
        {
            guna2ComboBox2.Items.Add("Geraint");
        }
        else if (guna2ComboBox1.SelectedIndex == 5)
        {
            guna2ComboBox2.Items.Add("Alvaro");
            guna2ComboBox2.Items.Add("Elvira");
            guna2ComboBox2.Items.Add("Enrique");
            guna2ComboBox2.Items.Add("Conchita");
        }
        else if (guna2ComboBox1.SelectedIndex == 6)
        {
            guna2ComboBox2.Items.Add("Alonso");
            guna2ComboBox2.Items.Add("Paloma");
            guna2ComboBox2.Items.Add("Miguel");
            guna2ComboBox2.Items.Add("Penélope");
        }
        else if (guna2ComboBox1.SelectedIndex == 7)
        {
            guna2ComboBox2.Items.Add("Henri");
            guna2ComboBox2.Items.Add("Denise");
            guna2ComboBox2.Items.Add("Mathieu");
            guna2ComboBox2.Items.Add("Céline");
            guna2ComboBox2.Items.Add("Eloise (Child)");
            guna2ComboBox2.Items.Add("Brigitte");
        }
        else if (guna2ComboBox1.SelectedIndex == 8)
        {
            guna2ComboBox2.Items.Add("Antoine");
            guna2ComboBox2.Items.Add("Sylvie");
            guna2ComboBox2.Items.Add("Jean");
            guna2ComboBox2.Items.Add("Chantal");
        }
        else if (guna2ComboBox1.SelectedIndex == 9)
        {
            guna2ComboBox2.Items.Add("Duarte");
            guna2ComboBox2.Items.Add("Fernanda");
            guna2ComboBox2.Items.Add("Raquel");
            guna2ComboBox2.Items.Add("Cristiano");
            guna2ComboBox2.Items.Add("Inês");
        }
        else if (guna2ComboBox1.SelectedIndex == 10)
        {
            guna2ComboBox2.Items.Add("Antonio");
            guna2ComboBox2.Items.Add("Francisca");
            guna2ComboBox2.Items.Add("Ricardo");
            guna2ComboBox2.Items.Add("Vitòria");
        }
        else if (guna2ComboBox1.SelectedIndex == 11)
        {
            guna2ComboBox2.Items.Add("Conrad");
            guna2ComboBox2.Items.Add("Katja");
            guna2ComboBox2.Items.Add("Hans");
            guna2ComboBox2.Items.Add("Vicki");
            guna2ComboBox2.Items.Add("Marlene");
        }
        else if (guna2ComboBox1.SelectedIndex == 12)
        {
            guna2ComboBox2.Items.Add("Diego");
            guna2ComboBox2.Items.Add("Isabella");
            guna2ComboBox2.Items.Add("Elsa");
            guna2ComboBox2.Items.Add("Giorgio");
            guna2ComboBox2.Items.Add("Carla");
        }
        else if (guna2ComboBox1.SelectedIndex == 13)
        {
            guna2ComboBox2.Items.Add("Colette");
            guna2ComboBox2.Items.Add("Maarten");
            guna2ComboBox2.Items.Add("Fenna");
            guna2ComboBox2.Items.Add("Ruben");
            guna2ComboBox2.Items.Add("Lotte");
        }
        else if (guna2ComboBox1.SelectedIndex == 14)
        {
            guna2ComboBox2.Items.Add("Mattias");
            guna2ComboBox2.Items.Add("Sofie");
            guna2ComboBox2.Items.Add("Hillevi");
            guna2ComboBox2.Items.Add("Astrid");
        }
        else if (guna2ComboBox1.SelectedIndex == 15)
        {
            guna2ComboBox2.Items.Add("Christel");
            guna2ComboBox2.Items.Add("Jeppe");
            guna2ComboBox2.Items.Add("Naja");
            guna2ComboBox2.Items.Add("Mads");
        }
        else if (guna2ComboBox1.SelectedIndex == 16)
        {
            guna2ComboBox2.Items.Add("Karl");
            guna2ComboBox2.Items.Add("Dòra");
        }
        else if (guna2ComboBox1.SelectedIndex == 17)
        {
            guna2ComboBox2.Items.Add("Finn");
            guna2ComboBox2.Items.Add("Pernille");
            guna2ComboBox2.Items.Add("Iselin");
            guna2ComboBox2.Items.Add("Liv");
        }
        else if (guna2ComboBox1.SelectedIndex == 18)
        {
            guna2ComboBox2.Items.Add("Marek");
            guna2ComboBox2.Items.Add("Agnieszka");
            guna2ComboBox2.Items.Add("Zofia");
            guna2ComboBox2.Items.Add("Maja");
            guna2ComboBox2.Items.Add("Jan");
            guna2ComboBox2.Items.Add("Jacek");
            guna2ComboBox2.Items.Add("Ewa");
            guna2ComboBox2.Items.Add("Finn");
            guna2ComboBox2.Items.Add("Finn");
            guna2ComboBox2.Items.Add("Finn");
            guna2ComboBox2.Items.Add("Finn");
        }
        else if (guna2ComboBox1.SelectedIndex == 19)
        {
            guna2ComboBox2.Items.Add("Emil");
            guna2ComboBox2.Items.Add("Alina");
            guna2ComboBox2.Items.Add("Carmen");
        }
        else if (guna2ComboBox1.SelectedIndex == 20)
        {
            guna2ComboBox2.Items.Add("Ahmet");
            guna2ComboBox2.Items.Add("Emel");
            guna2ComboBox2.Items.Add("Filiz");
        }
        else if (guna2ComboBox1.SelectedIndex == 21)
        {
            guna2ComboBox2.Items.Add("Aled");
            guna2ComboBox2.Items.Add("Nia");
            guna2ComboBox2.Items.Add("Gwyneth");
        }
        else if (guna2ComboBox1.SelectedIndex == 22)
        {
            guna2ComboBox2.Items.Add("Maxim");
            guna2ComboBox2.Items.Add("Tatyana");
        }

        guna2ComboBox2.SelectedIndex = 0;
    }

    private void guna2Button1_Click(object sender, System.EventArgs e)
    {
        driver.Close();
        driver.Quit();
        driver = UndetectedChromeDriver.UndetectedChromeDriver.Create(driverExecutablePath: Application.StartupPath + "\\chromedriver.exe", headless: true);
        driver.MaximizeWindow();
        driver.GoToUrl("https://www.naturalreaders.com/");
        driver.GoToUrl("https://www.naturalreaders.com/online/");
        driver.FindLoadedElement(By.Id("pw_languages")).Click();

        for (int i = 0; i < guna2ComboBox1.SelectedIndex; i++)
        {
            Actions actions = new Actions(driver);
            actions.SendKeys(OpenQA.Selenium.Keys.ArrowDown).Build().Perform();
        }

        Actions actions1 = new Actions(driver);
        actions1.SendKeys(OpenQA.Selenium.Keys.Enter).Build().Perform();
        driver.FindLoadedElement(By.Id("pw-free-list"));
        string urlToCheck = "";

        if (guna2ComboBox1.SelectedIndex == 0)
        {
            urlToCheck = $"https://wwwnaturalreaderscom.s3.amazonaws.com/comm2022-portraits/english/{guna2ComboBox2.SelectedItem.ToString()}.jpg";
        }
        else if (guna2ComboBox1.SelectedIndex == 1)
        {
            urlToCheck = $"https://wwwnaturalreaderscom.s3.amazonaws.com/comm2022-portraits/english/{guna2ComboBox2.SelectedItem.ToString()}.jpg";
        }
        else if (guna2ComboBox1.SelectedIndex == 2)
        {
            urlToCheck = $"https://wwwnaturalreaderscom.s3.amazonaws.com/comm2022-portraits/english/{guna2ComboBox2.SelectedItem.ToString()} (Australia).jpg";
        }
        else if (guna2ComboBox1.SelectedIndex == 3)
        {
            urlToCheck = $"https://wwwnaturalreaderscom.s3.amazonaws.com/comm2022-portraits/english/{guna2ComboBox2.SelectedItem.ToString()} (India).jpg";
        }
        else if (guna2ComboBox1.SelectedIndex == 4)
        {
            urlToCheck = $"https://wwwnaturalreaderscom.s3.amazonaws.com/comm2022-portraits/english/{guna2ComboBox2.SelectedItem.ToString()} (Wales).jpg";
        }
        else if (guna2ComboBox1.SelectedIndex == 5)
        {
            urlToCheck = $"https://wwwnaturalreaderscom.s3.amazonaws.com/comm2022-portraits/spanish/{guna2ComboBox2.SelectedItem.ToString()}.jpg";
        }
        else if (guna2ComboBox1.SelectedIndex == 6)
        {
            urlToCheck = $"https://wwwnaturalreaderscom.s3.amazonaws.com/comm2022-portraits/spanish/{guna2ComboBox2.SelectedItem.ToString()}.jpg";
        }
        else if (guna2ComboBox1.SelectedIndex == 7)
        {
            urlToCheck = $"https://wwwnaturalreaderscom.s3.amazonaws.com/comm2022-portraits/french/{guna2ComboBox2.SelectedItem.ToString()}.jpg";
        }
        else if (guna2ComboBox1.SelectedIndex == 8)
        {
            urlToCheck = $"https://wwwnaturalreaderscom.s3.amazonaws.com/comm2022-portraits/french/{guna2ComboBox2.SelectedItem.ToString()}.jpg";
        }
        else if (guna2ComboBox1.SelectedIndex == 9)
        {
            urlToCheck = $"https://wwwnaturalreaderscom.s3.amazonaws.com/comm2022-portraits/portuguese/{guna2ComboBox2.SelectedItem.ToString()}.jpg";
        }
        else if (guna2ComboBox1.SelectedIndex == 10)
        {
            urlToCheck = $"https://wwwnaturalreaderscom.s3.amazonaws.com/comm2022-portraits/portuguese/{guna2ComboBox2.SelectedItem.ToString()}.jpg";
        }
        else if (guna2ComboBox1.SelectedIndex == 11)
        {
            urlToCheck = $"https://wwwnaturalreaderscom.s3.amazonaws.com/comm2022-portraits/german/{guna2ComboBox2.SelectedItem.ToString()}.jpg";
        }
        else if (guna2ComboBox1.SelectedIndex == 12)
        {
            urlToCheck = $"https://wwwnaturalreaderscom.s3.amazonaws.com/comm2022-portraits/italian/{guna2ComboBox2.SelectedItem.ToString()}.jpg";

            if (guna2ComboBox2.SelectedItem.ToString() == "Giorgio")
            {
                urlToCheck = $"https://wwwnaturalreaderscom.s3.amazonaws.com/comm2022-portraits/italian/Francesco.jpg";
            }
            else if (guna2ComboBox2.SelectedItem.ToString() == "Giorgio")
            {
                urlToCheck = $"https://wwwnaturalreaderscom.s3.amazonaws.com/comm2022-portraits/italian/Giulia.jpg";
            }
        }
        else if (guna2ComboBox1.SelectedIndex == 13)
        {
            urlToCheck = $"https://wwwnaturalreaderscom.s3.amazonaws.com/comm2022-portraits/dutch/{guna2ComboBox2.SelectedItem.ToString()}.jpg";
        }
        else if (guna2ComboBox1.SelectedIndex == 14)
        {
            urlToCheck = $"https://wwwnaturalreaderscom.s3.amazonaws.com/comm2022-portraits/swedish/{guna2ComboBox2.SelectedItem.ToString()}.jpg";
        }
        else if (guna2ComboBox1.SelectedIndex == 15)
        {
            urlToCheck = $"https://wwwnaturalreaderscom.s3.amazonaws.com/comm2022-portraits/danish/{guna2ComboBox2.SelectedItem.ToString()}.jpg";
        }
        else if (guna2ComboBox1.SelectedIndex == 16)
        {
            urlToCheck = $"https://wwwnaturalreaderscom.s3.amazonaws.com/comm2022-portraits/icelandic/{guna2ComboBox2.SelectedItem.ToString()}.jpg";
        }
        else if (guna2ComboBox1.SelectedIndex == 17)
        {
            urlToCheck = $"https://wwwnaturalreaderscom.s3.amazonaws.com/comm2022-portraits/norwegian/{guna2ComboBox2.SelectedItem.ToString()}.jpg";
        }
        else if (guna2ComboBox1.SelectedIndex == 18)
        {
            urlToCheck = $"https://wwwnaturalreaderscom.s3.amazonaws.com/comm2022-portraits/polish/{guna2ComboBox2.SelectedItem.ToString()}.jpg";
        }
        else if (guna2ComboBox1.SelectedIndex == 19)
        {
            urlToCheck = $"https://wwwnaturalreaderscom.s3.amazonaws.com/comm2022-portraits/romanian/{guna2ComboBox2.SelectedItem.ToString()}.jpg";
        }
        else if (guna2ComboBox1.SelectedIndex == 20)
        {
            urlToCheck = $"https://wwwnaturalreaderscom.s3.amazonaws.com/comm2022-portraits/turkish/{guna2ComboBox2.SelectedItem.ToString()}.jpg";
        }
        else if (guna2ComboBox1.SelectedIndex == 21)
        {
            urlToCheck = $"https://wwwnaturalreaderscom.s3.amazonaws.com/comm2022-portraits/welsh/{guna2ComboBox2.SelectedItem.ToString()}.jpg";
        }
        else if (guna2ComboBox1.SelectedIndex == 22)
        {
            urlToCheck = $"https://wwwnaturalreaderscom.s3.amazonaws.com/comm2022-portraits/russian/{guna2ComboBox2.SelectedItem.ToString()}.jpg";
        }

        driver.FindLoadedElement(By.Id("pw-free-list"));
        driver.FindLoadedElementByTagValue("src", urlToCheck).Click();
        driver.FindLoadedElementByTagValue("aria-label", "next to NaturalReader online content").Click();
    }

    private void guna2Button2_Click(object sender, System.EventArgs e)
    {
        driver.FindLoadedElement(By.Id("inputDiv")).Click();
        driver.ExecuteScript($"document.getElementById(\"inputDiv\").innerText = \"{guna2TextBox1.Text}\"");
        driver.ExecuteScript("document.getElementsByClassName(\"mat-button-wrapper\")[4].click();");
        System.Threading.Thread.Sleep(2000);
        driver.ExecuteScript("document.getElementsByClassName(\"mat-button-wrapper\")[5].click();");
    }

    private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
    {
        try
        {
            driver.Close();
            driver.Quit();
        }
        catch
        {

        }
    }
}