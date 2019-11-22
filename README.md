# AuthHelper
Simple helper for authenticating users using Token in .NET Web API



# How to use

initialize <b>ConnectionConfigModel</b>

<pre>

ConnectionConfigModel authConfig = new ConnectionConfigModel() {
            BaseUrl = "http://192.168.12.7:45498/Token",
            Username = "Root",
            Password = "Toor"
          };

</pre>

then call the authenticate function by <b>await Authenticate(authConfig)</b> function and pass the config parameter

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
