function ShowHidePassword() {
    const buttons = document.querySelectorAll('.show-hide-password');
    buttons.forEach((el) => {
        el.dataset.originalLabel = el.ariaLabel;
        el.addEventListener('click', (e) => {
            e.preventDefault();
            const button = e.currentTarget;
            const icon = button.querySelector('i');
            const target = document.querySelector(button.dataset.target);
            if (target) {
                if (target.type === 'password') {
                    button.ariaLabel = "Hide Password";
                    button.setAttribute('title', 'Hide Password');
                    icon.classList.remove('fa-eye');
                    icon.classList.add('fa-eye-slash');
                    target.type = 'text';
                } else {
                    target.type = 'password';
                    button.ariaLabel = button.dataset.originalLabel;
                    button.setAttribute('title', button.dataset.originalLabel);
                    icon.classList.remove('fa-eye-slash');
                    icon.classList.add('fa-eye');
                }
            }
        })
    });
}

document.addEventListener('DOMContentLoaded', () => {
    ShowHidePassword();
});
