$(document).ready(function () {
    // check for local storage of dark mode and font size
    if (localStorage.darkMode == 1) {
        $("*").addClass("dark-mode");
    }
    if (localStorage.fontSize) {
        if (localStorage.fontSize > 0) {
            for (let i = 0; i < localStorage.fontSize; i++) {
                $("*").css("font-size", "+=1");
            }
        } else if (localStorage.fontSize < 0) {
            for (let i = 0; i > localStorage.fontSize; i--) {
                $("*").css("font-size", "-=1");
            }
        }
    } else {
        localStorage.setItem("fontSize", "0");
    }

    // change font size on click
    $("#font-increase").click(function () {
        let fontSize = localStorage.fontSize;
        $("*").css("font-size", "+=1");
        ++fontSize;
        localStorage.setItem("fontSize", fontSize);
    });
    $("#font-decrease").click(function () {
        let fontSize = localStorage.fontSize;
        $("*").css("font-size", "-=1");
        --fontSize;
        localStorage.setItem("fontSize", fontSize);
    });
    $("#font-reset").click(function () {
        localStorage.setItem("fontSize", "0");
        location.reload();
    });

    // change between dark and light mode
    $("#dark-mode").click(function () {
        $("*").addClass("dark-mode");
        localStorage.setItem("darkMode", "1");

    })
    $("#light-mode").click(function () {
        $("*").removeClass("dark-mode");
        localStorage.setItem("darkMode", "0");
    })

    // thumbnail image modal funcionality
    $(".thumbnail").click(function () {
        $(".modal").css("display", "block");
        $(".modal-content").attr("src", $(".thumbnail").attr("src"));
        $(".caption").html(this.alt);
    });
    $(".close").click(function () {
        $(".modal").css("display", "none");
    });
});
