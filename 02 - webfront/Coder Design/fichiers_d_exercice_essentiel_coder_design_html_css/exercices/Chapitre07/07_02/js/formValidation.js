//get the contact form
const contactForm = document.getElementById('contactForm');
//add the submit event listener
contactForm.addEventListener('submit', handleSubmit, false);

//handleSubmit function
function handleSubmit(e) {
    //prevent default submit behavior
    e.preventDefault();
    //get the form fields
    const fields = contactForm.elements;
    //transfor fields in an array and loop around it
    [...fields].forEach(field => {
        //add on blur listener for each field if not yet attached
        field.addEventListener('blur', () => {
            validateField(field)
        }, false);
        //check the validity of the field right now;
        validateField(field);
    })
}

function validateField(field) {
    if(!field.checkValidity()){
        //add invalid class to fields that do not validate
        field.classList.add('invalid');
    } else {
        field.classList.remove('invalid');
    }
}
