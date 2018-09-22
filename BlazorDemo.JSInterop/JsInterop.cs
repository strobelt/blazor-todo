using Microsoft.JSInterop;
using System.Threading.Tasks;

namespace BlazorDemo.JSInterop
{
    public class JsInterop
    {
        public static Task<bool> Confirm(string message)
        {
            // Implemented in exampleJsInterop.js
            return JSRuntime.Current.InvokeAsync<bool>(
                "jsFunctions.showConfirm",
                message);
        }
    }
}
