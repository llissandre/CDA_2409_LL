let contactForm = document.getElementById('frmContact');
//grasp fields to validate
let fields = document.querySelectorAll('input[required], textarea[required]');
fields.forEach((field) => {
    field.addEventListener('focus', (e) => resetField(field), false);
    field.addEventListener('blur',(e) =>  validateField(field), false)
})


contactForm.addEventListener('submit', (e) => {
    e.preventDefault();
    //reset all fields
    fields.forEach((field) => resetField(field))
    //initialize valid variable as true
    let valid = true;
    fields.forEach((field) => {
        if(! validateField(field)){
            valid = false;
        }
    });//end forEach()
    //Submit form if all fields valid
    if(valid){
        //e.target.submit();
    }
}, false);

function validateField(field){
    if(field.checkValidity()){
        return true;
    } else {
        //add invalid class to field
        field.classList.add('invalid')
        //get default message or title attribute if any
        let message = field.title ? field.title : field.validationMessage;
        //add validation message in the Dom
        field.previousElementSibling.insertAdjacentHTML('beforeend', `<span class="msg">${message}</span>`);
        return false
    }
}
function resetField(field){
    let fieldLabel = field.previousElementSibling;
    field.classList.remove('invalid', 'valid');
    while (fieldLabel.firstElementChild){
        fieldLabel.removeChild(fieldLabel.firstElementChild)
    }
    field.valid = true;
}

