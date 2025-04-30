document.addEventListener("DOMContentLoaded", function () {
    const toggleSwitch = document.getElementById("theme-toggle");
    const body = document.body;

    // Check if there's a saved theme preference
    if (localStorage.getItem("theme") === "dark") {
        body.classList.add("dark-mode");
        toggleSwitch.checked = true;
    }

    // Listen for theme toggle
    toggleSwitch.addEventListener("change", function () {
        if (this.checked) {
            body.classList.add("dark-mode");
            localStorage.setItem("theme", "dark");
        } else {
            body.classList.remove("dark-mode");
            localStorage.setItem("theme", "light");
        }
    });
});
