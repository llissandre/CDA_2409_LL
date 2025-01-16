startDate = document.getElementById('start_date');
endDate = document.getElementById('end_date');

// Convert today date to input format
const today = new Date().toISOString().split('T')[0];
startDate.value = today;
startDate.min = today;

// Tomorrow date calc
let tomorrow = new Date();
tomorrow.setDate(tomorrow.getDate() + 1);

// Convert tomorrow to input format
let tomorrowFormat = tomorrow.toISOString().split('T')[0];
endDate.value = tomorrowFormat;
endDate.min = tomorrowFormat;

startDate.addEventListener('change', (e) => {
    let day = new Date(e.target.value);

    if (endDate.value < startDate.value) {
        day.setDate(day.getDate() + 1);
        endDate.value = day.toISOString().split('T')[0];
    }
});

endDate.addEventListener('change', (e) => {
    let day = new Date(e.target.value);

    if (endDate.value < startDate.value) {
        day.setDate(day.getDate() - 1);
        startDate.value = day.toISOString().split('T')[0];
    }
})
