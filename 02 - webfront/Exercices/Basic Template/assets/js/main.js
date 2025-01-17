
function showResponsiveMenu() {
    var menu = document.getElementById("topnav-responsive-menu");
    var icon = document.getElementById("topnav-hamburger-icon");
    var root = document.getElementById("container-topnav");
    if (menu.className === "") {
      menu.className = "open";
      icon.className = "open";
      root.style.overflowY = "hidden";
    } else {
      menu.className = "";                    
      icon.className = "";
      root.style.overflowY = "";
    }
  }