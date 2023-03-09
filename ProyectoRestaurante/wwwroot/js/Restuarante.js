let menuIsActive = true
let sections = Array.from(document.getElementsByClassName("section"));

sections.forEach((targetSection) => {
    targetSection.addEventListener("click", (e) => {
        sections.forEach((section) => {
            if (targetSection != section)
                section.removeAttribute("open")
        })
    })
})

function switchSidebar() {
    let menu = document.querySelector("#menu")

    if (menuIsActive) {
        menu.classList
            .remove("menu--enabled");
        menu.classList
            .add("menu--disabled");
    } else {
        menu.classList
            .add("menu--enabled");
        menu.classList
            .remove("menu--disabled");
    }

    menuIsActive = !menuIsActive;
}

switchSidebar();