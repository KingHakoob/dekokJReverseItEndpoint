// Jacob Dekok
// 10/26/2022
// Reverse it API
// This program will reverse the users input
// Peer Reviewed By Carlos Felipe: This program is very neat. 
// It reverse whatever I typed in. Regardless if it was a number
// or string. Good program overall.


using Microsoft.AspNetCore.Mvc;

namespace dekokJReverseItEndpoint.Controllers;

[ApiController]
[Route("[controller]")]
public class ReverseItController : ControllerBase
{
    [HttpGet]
    [Route("Reverse/{word}")]

    public string ReverseIt(string word)
    {
        char[] charArray = word.ToCharArray();
        string reversedInput = "";

        for (int i = charArray.Length - 1; i > -1; i--)
        {

            reversedInput += charArray[i];
        }

        return reversedInput;
    }
}
