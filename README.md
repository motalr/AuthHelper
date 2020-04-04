# AuthHelper
Helper for authenticating users using OAuth2 Token in .NET Web API



# How to use



initialize <b>ConnectionConfigModel</b>
<p>
<b>*using AuthHelper.Models</b>
</p>
<pre>

ConnectionConfigModel authConfig = new ConnectionConfigModel() {
            BaseUrl = "http://192.168.12.7:45498/Token",
            Username = "Root",
            Password = "Toor"
          };

</pre>

<b>*using AuthHelper.Services</b>
<p>
then call the authenticate function by <b><i>await Connection.Authenticate(authConfig)</i></b> function and pass the config parameter
</p>
if the Authentication is successfull the return response will contain

<pre>
    <table style="width:100%">
      <tr>
        <td>AccessToken</td>
      </tr>
      <tr>
        <td>RefreshToken</td>
      </tr>
      <tr>
        <td>TokenType</td>
      </tr>
      <tr>
        <td>ExpiresInMilliseconds</td>
      </tr>
      <tr>
        <td>Username</td>
      </tr>
      <tr>
        <td>IssuedOn</td>
      </tr>
      <tr>
        <td>ExpiresOn</td>
      </tr>
      <tr>
        <td>Error</td>
      </tr>
      <tr>
        <td>ErrorDescription</td>
      </tr>
     
    </table>
</pre>

<br>
<p><a href="https://www.buymeacoffee.com/7lCZ9si" rel="nofollow"><img src="https://camo.githubusercontent.com/b8efed595794b7c415163a48f4e4a07771b20abe/68747470733a2f2f7777772e6275796d6561636f666665652e636f6d2f6173736574732f696d672f637573746f6d5f696d616765732f707572706c655f696d672e706e67" alt="Buy Me A Coffee" data-canonical-src="https://www.buymeacoffee.com/assets/img/custom_images/purple_img.png" style="max-width:100%;"></a></p>

