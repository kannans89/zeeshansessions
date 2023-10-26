function modalFocus() {
    // add all the elements inside modal which you want to make focusable
    const focusableSelectors = 'button, [href], input, select, textarea, [tabindex]:not([tabindex="-1"])';
    const modals = $('.modal');
    let openModal;
    modals.on('shown.bs.modal', function () {
        openModal = this;
        const focusables = this.querySelectorAll(focusableSelectors);
        if (focusables && focusables.length > 0) {
            this.gdFirstElement = focusables[0];
            this.gdLastElement = focusables[focusables.length - 1];
            this.gdFirstElement.focus();
        }
    });
    modals.on('hidden.bs.modal', function () {
        openModal = null;
        if (this.gdFirstElement) delete this.gdFirstElement;
        if (this.gdLastElement) delete this.gdLastElement;
    });

    document.addEventListener('keydown', function(e) {
        if (!openModal) return;

        let isTabPressed = e.key === 'Tab' || e.keyCode === 9;

        if (!isTabPressed) {
            return;
        }

        if (e.shiftKey) { // if shift key pressed for shift + tab combination
            if (document.activeElement === openModal.gdFirstElement) {
                openModal.gdLastElement.focus(); // add focus for the last focusable element
                e.preventDefault();
            }
        } else { // if tab key is pressed
            if (document.activeElement === openModal.gdLastElement) { // if focused has reached to last focusable element then focus first focusable element after pressing tab
                openModal.gdFirstElement.focus(); // add focus for the first focusable element
                e.preventDefault();
            }
        }
    });
}

document.addEventListener('DOMContentLoaded', function() {
    modalFocus();
});
