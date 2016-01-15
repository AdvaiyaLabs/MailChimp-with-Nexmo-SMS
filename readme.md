#MailChimp with Nexmo SMS
<img src="https://github.com/AdvaiyaLabs/Mailchimp-with-Nexmo-SMS/blob/master/Docs/image1.jpeg" width=200>

##Introduction 

**MailChimp with Nexmo SMS** app allows users to send SMS to all the subscribers available in the MailChimp email campaign. MailChimp integration with this app allows MailChimp users to send SMS campaigns to their subscribers in over 200 countries.

##Use Case

MailChimp user wants to send SMS to all the contacts available in the MailChimp campaign along with the email. The app allows the user to select the campaign and send SMS to the associated contact list.

##Prerequisite

-   This app requires Nexmo subscription and corresponding Nexmo API keys (Keys and Secret). To access the API keys, see appendix (“Nexmo API Keys”)

-   This app requires MailChimp subscription and corresponding MailChimp API key. To access the API keys, see appendix (“MailChimp API Keys”)

-   In MailChimp list, *Phone number* should be in the international format. To add the phone number field in the MailChimp list, see appendix (“Add phone number filed in MailChimp list”)

Features

-   Send an Email to all the subscribers available in the MailChimp email campaign

-   Send SMS to all the subscribers available in the MailChimp email campaign

-   Customize SMS message with a replaceable parameter of MailChimp list

-   Enable and disable SMS

##Steps to install the MailChimp with Nexmo SMS app 

1.  Visit the target repository using the URL &lt;Nexmo App Github URL&gt;

2.  Click on the "Download ZIP" as shown in image.

<img src="https://github.com/AdvaiyaLabs/Mailchimp-with-Nexmo-SMS/blob/master/Docs/image3.png" width=600>

1.  Extract ZIP file

2.  Install **MailChimp with Nexmo SMS** app on your local device.

3.  **MailChimp with Nexmo SMS** Wizard opens up. In this window, click on the **Next** button

<img src="https://github.com/AdvaiyaLabs/Mailchimp-with-Nexmo-SMS/blob/master/Docs/image4.png" width=600>

1.  Change the destination folder for installation and click **Next**

    <img src="https://github.com/AdvaiyaLabs/Mailchimp-with-Nexmo-SMS/blob/master/Docs/image5.png" width=600>

2.  See the current settings and click **Install**

    <img src="https://github.com/AdvaiyaLabs/Mailchimp-with-Nexmo-SMS/blob/master/Docs/image6.png" width=600>

3.  Click on **Finish** and the shortcut for **MailChimp with Nexmo SMS** app will be created on your desktop

 ##<span id="_Toc440363277" class="anchor"><span id="_Toc440363349" class="anchor"></span></span><img src="https://github.com/AdvaiyaLabs/Mailchimp-with-Nexmo-SMS/blob/master/Docs/image7.png" width=600>

##Steps to use the MailChimp with Nexmo SMS app 

1.  Double click on the app icon on desktop or go to the *Start* menu, type “MailChimp with Nexmo SMS.exe” and select “MailChimp with Nexmo SMS”.

> <img src="https://github.com/AdvaiyaLabs/Mailchimp-with-Nexmo-SMS/blob/master/Docs/image8.png" width=600>

1.  The settings form will open up. Provide **Nexmo Key**, **Nexmo Secret** and **MailChimp API Key,** and click on **Save**.

<img src="https://github.com/AdvaiyaLabs/Mailchimp-with-Nexmo-SMS/blob/master/Docs/image9.png" width=600>

1.  This settings will be saved for later use, which can be updated from the menu later on.

2.  Select campaign from the campaign list.

    <img src="https://github.com/AdvaiyaLabs/Mailchimp-with-Nexmo-SMS/blob/master/Docs/image10.png" width=600>

3.  On the selection of a campaign, it will auto-populate “Campaign Title”, “Campaign Subject”, “Campaign From Name”, “Campaign From Email” from MailChimp database.

4.  To send an SMS, check **Enable SMS** checkbox.

<img src="https://github.com/AdvaiyaLabs/Mailchimp-with-Nexmo-SMS/blob/master/Docs/image11.png" width=600>

1.  If “Enable SMS” is checked, the app will display another Nexmo detailed form on clicking the **Next** button. If the user do not check “Enable SMS”, it will send only emails

2.  The form has the following fields:

-   **Select recipient Field**: Displays all “Phone” type field Like Home Phone, Work Phone, Mobile.

-   **Message**: User can type a customized message with replaceable parameters. For example - if the user wants to send a message Hello &lt;&lt;name&gt;&gt;, then the user can type “Hello” and select **FNAME** from the list box. It will replace **FNAME** with the first name of the contact from the MailChimp list.

-   **Select tag**: This list box displays all fields available in MailChimp list.

> <img src="https://github.com/AdvaiyaLabs/Mailchimp-with-Nexmo-SMS/blob/master/Docs/image12.png" width=600>

1.  After clicking on **Send Campaign** button, it will ask for confirmation – **Yes** or **No.**

    <img src="https://github.com/AdvaiyaLabs/Mailchimp-with-Nexmo-SMS/blob/master/Docs/image13.png" width=600>

2.  After confirmation, the campaign will start sending emails with SMS to all the contacts listed in that campaign.

3.  If there is some issue in sending the campaign, the following message will be shown by the app:

<img src="https://github.com/AdvaiyaLabs/Mailchimp-with-Nexmo-SMS/blob/master/Docs/image14.png" width=600>

##Appendix

Nexmo API Keys
--------------

-   To access the Nexmo keys, go to <https://www.nexmo.com/> and Sign-in

-   On the top right corner, click on the **Api Settings**.

-   Key and Secret will display in the top bar as shown in the below image:

> <img src="https://github.com/AdvaiyaLabs/Mailchimp-with-Nexmo-SMS/blob/master/Docs/image15.png" width=600>

MailChimp API Keys
------------------

-   To access the MailChimp API keys, go to <http://mailchimp.com/> and Sign-in.

-   Go to your profile information on the top right corner and click on **Account**.

    <img src="https://github.com/AdvaiyaLabs/Mailchimp-with-Nexmo-SMS/blob/master/Docs/image16.png" width=600>

-   Go to Extras -&gt; API keys.

> <img src="https://github.com/AdvaiyaLabs/Mailchimp-with-Nexmo-SMS/blob/master/Docs/image17.png" width=600>

-   On “Your API keys” section, click on **Create A Key** button.

> <img src="https://github.com/AdvaiyaLabs/Mailchimp-with-Nexmo-SMS/blob/master/Docs/image18.png" width=600>

-   After that it will generate an API key.

> <img src="https://github.com/AdvaiyaLabs/Mailchimp-with-Nexmo-SMS/blob/master/Docs/image19.png" width=600>

Add phone number field in MailChimp list
----------------------------------------

To add phone field in the list, follow the below steps:

-   Sign-in to MailChimp and go to **Lists** menu on the top bar. It will display all the lists. Click on the corresponding list.

> <img src="https://github.com/AdvaiyaLabs/Mailchimp-with-Nexmo-SMS/blob/master/Docs/image20.png" width=600>

-   Now go to Settings -&gt; List fields and \*|MERGE|\* tags

    <img src="https://github.com/AdvaiyaLabs/Mailchimp-with-Nexmo-SMS/blob/master/Docs/image21.png" width=600>

-   Click on “Add a Field” button.

    <img src="https://github.com/AdvaiyaLabs/Mailchimp-with-Nexmo-SMS/blob/master/Docs/image22.png" width=600>

-   Select **Phone**. <img src="https://github.com/AdvaiyaLabs/Mailchimp-with-Nexmo-SMS/blob/master/Docs/image23.png" width=600>

-   Now provide “Field label and type”, “Required?”, “Put this tag in your content” and click on **Save Changes** button.

    <img src="https://github.com/AdvaiyaLabs/Mailchimp-with-Nexmo-SMS/blob/master/Docs/image24.png" width=600>
