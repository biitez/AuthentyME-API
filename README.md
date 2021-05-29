# AuthentyME-API
## C# Rest API for Authenty-ME authentication system. [https://github.com/biitez/Authenty-ME]

## Example Usage:
```csharp
// Shitty Example.

// create a new authentyclient instance.
var client = new AuthentyClient("YOUR_USER_API_KEY", "APPLICATION_KEY");

// try to ban user
var ban = await client.BanUser("SOME_USER");

// check result omggg
if (ban.success)
{
  Console.WriteLine("[SUCCES]: Banned User!");
  return;
}
switch (ban.status)
{
  case "ALREADY_BANNED":
    Console.WriteLine("[ERROR]: User is already banned!");
    break;
  case "UNFOUND_USER":
    Console.WriteLine("[ERROR]: Unable to find user!");
    break;
  default:
    Console.WriteLine($"[ERROR]: Unknown Response! {ban.status}");
    break;
}


```
#### Note: My first Rest API in C#
