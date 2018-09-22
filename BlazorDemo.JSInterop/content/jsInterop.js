// This file is to show how a library package may provide JavaScript interop features
// wrapped in a .NET API

window.jsFunctions = {
  showConfirm: function (message) {
    return confirm(message);
  }
};
