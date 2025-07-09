window.activatePersianDatePicker = function (id) {
    const element = document.getElementById(id);
    if (!element) return;

    $(element).persianDatepicker({
        format: 'YYYY/MM/DD',
        observer: true,
        initialValue: false,
        autoClose: true
    });
};

window.jsTest = function () {
    alert("✅ jsTest is working!");
};
