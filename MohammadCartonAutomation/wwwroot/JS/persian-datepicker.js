{
    window.activatePersianDatePicker = (elementId) => {
        $("#" + elementId).persianDatepicker({
            format: 'YYYY/MM/DD',
            initialValueType: 'gregorian',
            calendarType: 'persian',
            autoClose: true
        });
    };
}