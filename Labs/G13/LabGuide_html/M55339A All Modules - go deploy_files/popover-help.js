document.addEventListener('DOMContentLoaded', () => {
    $('.popover-help').popover({
        container: "body",
        placement: "top",
        trigger: "manual focus",
        boundary: "window",
        animation: false
    })
        .on("mouseenter", function() {
            var _this = this;
            $(this).popover("show");
            $(".popover").on("mouseleave", function() {
                $(_this).popover('hide');
            });
        }).on("mouseleave", function() {
        var _this = this;
        setTimeout(function() {
            if (!$(".popover:hover").length) {
                $(_this).popover("hide");
            }
        }, 300);
    });
});
