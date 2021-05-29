# AuthentyME-API
## C# Library to interact with Authenty-ME API. [https://github.com/biitez/Authenty-ME]

## Example Usage:
```csharp
var client = new AuthentyClient("YOUR_USER_API_KEY", "APPLICATION_KEY");
var ban = await client.BanUser("SOME_USER");
if (ban.success)
{
    Console.WriteLine("[SUCCES]: Banned User!");
}
else
{
    Console.WriteLine("[ERROR]: Could not ban User!");
}
```
## Todo:
- Enum for endpoints instead of dictionary.
- Go outside.
