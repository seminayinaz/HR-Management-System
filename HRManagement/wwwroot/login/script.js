// Password toggle functionality
document
  .getElementById("togglePassword")
  .addEventListener("click", function () {
    const passwordInput = document.getElementById("password");
    const toggleIcon = this.querySelector("i");

    if (passwordInput.type === "password") {
      passwordInput.type = "text";
      toggleIcon.classList.remove("fa-eye");
      toggleIcon.classList.add("fa-eye-slash");
    } else {
      passwordInput.type = "password";
      toggleIcon.classList.remove("fa-eye-slash");
      toggleIcon.classList.add("fa-eye");
    }
  });

// Form submission
document.getElementById("loginForm").addEventListener("submit", function (e) {
  e.preventDefault();

  const loginBtn = document.getElementById("loginBtn");
  const spinner = document.getElementById("spinner");
  const btnText = document.getElementById("btnText");
  const errorMessage = document.getElementById("errorMessage");
  const successMessage = document.getElementById("successMessage");

  // Hide previous messages
  errorMessage.classList.add("d-none");
  successMessage.classList.add("d-none");

  // Show loading state
  loginBtn.disabled = true;
  spinner.classList.remove("d-none");
  btnText.textContent = "Giriş yapılıyor...";

  // Simulate form processing (replace with actual backend call)
  setTimeout(() => {
    // Reset button state
    loginBtn.disabled = false;
    spinner.classList.add("d-none");
    btnText.textContent = "GİRİŞ YAP";

    // Show success message (replace with actual validation)
    document.getElementById("successText").textContent =
      "Giriş başarılı! Yönlendiriliyorsunuz...";
    successMessage.classList.remove("d-none");

    // Here you would typically redirect to dashboard
    // window.location.href = '/dashboard';
  }, 1500);
});

// Forgot password handler
document
  .getElementById("forgotPassword")
  .addEventListener("click", function (e) {
    e.preventDefault();
    console.log("Forgot password clicked");
    // Implement forgot password functionality
  });
