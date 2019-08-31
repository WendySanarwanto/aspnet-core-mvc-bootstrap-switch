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

ko.bindingHandlers.select2 = {
    init: (element, valueAccessor, allBindings, viewModel, bindingContext) => {
        var options = ko.unwrap(valueAccessor());
        // ko.unwrap(allBindings.get('selectedOptions'));
        console.log(`[debug] initialising select2. options arg: \n`, options);
        $(element).select2(options);
        console.log(`[debug] Select2 is initialised.`);
    },
    update: (element, valueAccessor, allBindings, viewModel, bindingContext) => {
        var options = ko.unwrap(valueAccessor());
        console.log(`[debug] select2 is updating.`);
        $(element).select2(options);
        console.log(`[debug] select2 is updated.`);
    }
};

class HomeViewModel {
    constructor(model){
        const self = this;
        let occupations = [];
        for(const occGroup of model.occupationGroups){
            occupations = [...occupations, ...(occGroup.occupations)]
        }
        self.Occupations = ko.observableArray(occupations);
        console.log(`self.Occupations: \n`, self.Occupations());
        // self.OccupationGroups = ko.mapping.fromJS(model.occupationGroups);
        self.SelectedOccupation = ko.observable('');

        self.Fullname = ko.observable('Laura Smith');
        self.Fullname.extend({
            required: {
                message: "Fullname cannot be left as empty."
            }
        });

        self.DateOfBirth = ko.observable(new Date());
        self.errors = ko.validation.group(self);
        self.isEnabled = ko.computed(() => {
            return self.errors().length > 0 ? false : true;
        });
        // self.Fullname = ko.observable('John Smith');
        // self.Fullname.subscribe(newVal => {
        //     console.log(`[debug] fullname: ${newVal}`);
        //     alert(newVal);
        // });
    }
}