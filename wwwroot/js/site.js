// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

$(document).ready(() => {
    $("[name='form-visibility-cb']").bootstrapSwitch();
    $("[name='form-visibility-cb']").on('switchChange.bootstrapSwitch', (e, state) => {
        const formVisibilityState = $("[name='form-visibility-cb']").bootstrapSwitch('state');
        console.log(`[debug] formVisibilityState=${formVisibilityState}`);
        console.log(`[debug] state=\n`, state);
        if (state) {
            $("#detail-form").show();
        } else {
            $("#detail-form").hide();
        }
    });

    $("#occupation-input").select2();
});