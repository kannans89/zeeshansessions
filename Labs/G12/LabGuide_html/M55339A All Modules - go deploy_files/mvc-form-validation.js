function MvcFormValidation() {
    const invalidInputs = document.querySelectorAll('.input-validation-error');
    if (invalidInputs && invalidInputs.length > 0) {
        invalidInputs.forEach((el) => {
            el.classList.remove('input-validation-error');
            el.classList.add('is-invalid');
            el.setAttribute('aria-invalid', 'true');

            const inputGroup = el.closest('.input-group');
            if (inputGroup && inputGroup.classList.contains('is-invalid') === false) {
                inputGroup.classList.add('is-invalid');
            }
        });

        invalidInputs[0].focus();
    }
    const validationMessages = document.querySelectorAll('.field-validation-error');
    if (validationMessages) {
        validationMessages.forEach((el) => {
            el.classList.remove('field-validation-error');
            el.classList.add('invalid-feedback');

            if (el.dataset.valmsgFor) {
                const input = document.querySelector(`#${el.dataset.valmsgFor}`)
                if (input) {
                    el.id = el.dataset.valmsgFor + 'Valmsg';
                    let ariaDescribedby = input.getAttribute('aria-describedby') || '';
                    ariaDescribedby = (el.dataset.valmsgFor + 'Valmsg ' + ariaDescribedby).trim();
                    input.setAttribute('aria-describedBy', ariaDescribedby);
                }
            }
        });
    }
}

document.addEventListener('DOMContentLoaded', () => {
    MvcFormValidation();
});
