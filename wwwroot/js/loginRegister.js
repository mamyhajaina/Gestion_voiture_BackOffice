$(document).ready(function () {
    $("#loginForm").on("submit", function (event) {
        event.preventDefault(); // Empêche le rechargement de la page

        var email = $("#email").val();
        var password = $("#password").val();

        console.log('----------*******------');

        $.ajax({
            url: "/LoginRegisterController/Login", // L'URL de votre méthode
            type: "POST",
            data: { email: email, password: password },
            success: function (response) {
                if (response.success) {
                    // Redirection en cas de succès
                    window.location.href = response.redirectUrl;
                } else {
                    // Affiche le message d'erreur
                    $("#error-message").text(response.message);
                }
            },
            error: function () {
                $("#error-message").text("Une erreur est survenue. Veuillez réessayer.");
            }
        });
    });


    $("#registerForm").on("submit", function (event) {
        event.preventDefault(); // Empêche le rechargement de la page

        var formData = {
            FirstName: $("#firstName").val(),
            LastName: $("#lastName").val(),
            Email: $("#email").val(),
            PasswordHash: $("#password").val()
        };

        $.ajax({
            url: "/LoginRegister/Register", // Remplacez par le chemin réel de votre méthode
            type: "POST",
            data: formData,
            success: function (response) {
                if (response.success) {
                    $("#success-message").text(response.message);
                    $("#error-message").text("");
                    // Redirection après un court délai
                    setTimeout(function () {
                        window.location.href = response.redirectUrl;
                    }, 2000);
                } else {
                    $("#error-message").text(response.message);
                    $("#success-message").text("");
                }
            },
            error: function () {
                $("#error-message").text("Une erreur est survenue. Veuillez réessayer.");
            }
        });
    });
});