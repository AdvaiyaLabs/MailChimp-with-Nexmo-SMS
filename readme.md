MailChimp NexmoMessenger

![](./media/image1.jpeg)

*“An app to send SMS with the MailChimp campaign”*

![](./media/image2.png)

Introduction 
=============

Nexmo Messenger app allows users to send SMS to all the subscribers available in the MailChimp email campaign. MailChimp integration with this app allows MailChimp users to send SMS campaigns to their subscribers in over 200 countries.

Use Case
========

> If the MailChimp user wants to send SMS to all the contacts available in the MailChimp campaign along with the email, then with the Nexmo Messenger app the user can send SMS to the selected list of contacts for a particular campaign.

Prerequisite
============

-   This app requires Nexmo subscription and corresponding Nexmo API keys (Keys and Secret). To access the API keys, see appendix (“Nexmo API Keys”)

-   This app requires MailChimp subscription and corresponding MailChimp API key. To access the API keys, see appendix (“MailChimp API Keys”)

-   In MailChimp list, *Phone number* should be in the international format. To add the phone number field in the MailChimp list, see appendix (“Add phone number filed in MailChimp list”)

Features

-   Send an Email to all the subscribers available in the Mail Chimp email campaign

-   Send SMS to all the subscribers available in the Mail Chimp email campaign

-   Customize SMS message with a replaceable parameter of Mail Chimp list

-   Enable and disable SMS

Steps to install the Nexmo Messenger App 
=========================================

1.  Download the setup and install Nexmo Messenger app for MailChimp

2.  Go to the *Start* menu and type “Nexmo Messenger.exe”

3.  Right click and select “Run as administrator”

> ![](./media/image3.png)

1.  **Nexmo Messenger** Wizard opens up. In this window, click on **Next** button

    ![](./media/image4.png)

2.  Select the destination folder for installation and click **Next**

    ![](./media/image4.png)

3.  See the current settings and click **Install**

    ![](./media/image5.png)

4.  Click on **Finish** and the shortcut for Nexmo Messenger app will be created on the desktop

    ![](./media/image6.png)

Steps to use the Nexmo Messenger App 
=====================================

1.  Double click on the App icon on desktop, the settings form will open up.

2.  Provide **Nexmo Key**, **Nexmo Secret** and **MailChimp API Key,** and click on **Save**.

![](./media/image7.png)

1.  This settings will be saved for later use, which can be updated from the menu later on.

2.  Select campaign from the campaign list.

    ![](./media/image8.png)

3.  On the selection of campaign, it will auto populate “campaign title”, “campaign subject”, “campaign from name”, “campaign from email” from MailChimp database.

4.  To send an SMS, check “Enable SMS” checkbox and click on **Next**.

5.  If “Enable SMS” is checked, the app will display another Nexmo detailed form on clicking **Next** button.

    ![](./media/image9.png)

6.  The form has the following fields:

-   **Select Recipient Field**: Displays all “Phone” type field Like Home Phone, Work Phone, Mobile.

-   **Message**: User can type a customized message with replaceable parameters. For example - if the user wants to send a message Hello &lt;&lt;name&gt;&gt;, then the user can type “Hello” and select **FNAME** from the list box. It will replace the **Fname** with the first name of the contact from the MailChimp list.

-   **Select tag**: This list box displays all fields available in MailChimp list.

> ![](./media/image10.png)

1.  After clicking on **Send Campaign** button, it will ask for confirmation – Yes or No.

    ![](./media/image11.png)

2.  After confirmation, the campaign will start sending emails with SMSs to all the contacts listed in that campaign. If the user do not check “Enable SMS”, it will send only emails.

3.  If there is some issue in sending the campaign, the following message will be shown by the app:

    ![](./media/image12.png)

Appendix
========

Nexmo API Keys
--------------

-   To access the Nexmo keys, go to <https://www.nexmo.com/> and Sign-in

-   On the top right corner, click on the **Api Settings**.

-   Key and Secret will display in the top bar as shown in the below image:

> ![](./media/image13.png)

MailChimp API Keys
------------------

-   To access the MailChimp API keys, go to <http://mailchimp.com/> and Sign-in.

-   Go to your profile information on the top right corner and click on **Account**.

    ![](./media/image14.png)

-   Go to Extras -&gt; API keys.

> ![](./media/image15.png)

-   On “Your API keys” section, click on **Create A Key** button.

> ![](./media/image16.png)

-   After that it will generate an API key.

> ![](./media/image17.png)

Add phone number field in MailChimp list
----------------------------------------

To add phone field in the list, follow the below steps:

-   Sign-in to MailChimp and go to **Lists** menu on the top bar. It will display all the lists. Click on the corresponding list.

> ![](./media/image18.png)

-   Now go to Settings -&gt; List fields and \*|MERGE|\* tags

    ![](./media/image19.png)

-   Click on “Add a Field” button, and select **Phone**.

![](./media/image20.png)

-   Now provide “Field label and type”, “Required”, “Put this tag in your content” and click on **Save Changes** button.

![](./media/image21.png)
