#pragma warning disable CA2227
namespace Deislabs.WAGI.Configuration
{
  using System.Collections.Generic;

  /// <summary>
  /// This class contains details of the WASM modules and entrypoints to be exposed.
  /// </summary>
  public class WASMModules
  {
    /// <summary>
    /// Gets or sets path where WASM Modules can be found.
    /// </summary>
    public string ModulePath { get; set; }

    /// <summary>
    /// Gets or sets details of modules that can be executed via the command line or HTTP Requests.
    /// </summary>
    public Dictionary<string, WASMModuleDetails> Modules { get; set; }
  }
}
#pragma warning restore CA2227
