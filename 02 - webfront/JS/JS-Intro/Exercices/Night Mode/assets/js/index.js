window.addEventListener("load", () => {
  if (window.localStorage.darkMode === "true") {
    document.body.classList.add("dark");
  }
});

darkMode.addEventListener("click", () => {
  document.body.classList.toggle("dark");

  if (window.localStorage.darkMode === "true") {
    window.localStorage.darkMode = "false";
  } else {
    window.localStorage.darkMode = "true";
  }
});
