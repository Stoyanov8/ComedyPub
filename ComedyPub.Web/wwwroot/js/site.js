function openNav() {
    document.getElementById("side").style.width = "150px";
    document.body.style.backgroundColor = "rgba(0,0,0,0.4)";
}

function closeNav() {
    document.getElementById("side").style.width = "0";
    document.body.style.backgroundColor = "white";
}

function AnimationButton() {
    let isChecked = $('#checkboxAnimation').is(':checked');
    sessionStorage.setItem('isChecked', isChecked);
    if (isChecked) {
        $('body').css('background-image', 'url(/images/giphy.gif)')
    } else {
        $('body').css('background-image', 'url(/images/stopped.gif)')
    }
}

function SaveAnimation() {

    let checked = sessionStorage.getItem('isChecked');

    if (checked === 'true') {
        $('#checkboxAnimation').prop('checked', true);
    }
    AnimationButton();
}
function GetSuitedBox() {
    let currentValue = $('#addContentSelect').val();
    let savedValue = sessionStorage.getItem('contentType');
 
    if (savedValue === undefined) {
        SaveTypeInSession('0');
    }
    else {
        SaveTypeInSession(currentValue);
    }

    if (currentValue === '1') {
        if (savedValue === '1') {
            return;
        }
        $('#inputContent').hide();
        $('#textAreaContent').show();

    } else if (currentValue !== '1') {
        if (savedValue === '0' || savedValue === '2') {
            return;
        }
        $('#inputContent').show();
        $('#textAreaContent').hide();
    }
}
function SaveTypeInSession(type) {
    sessionStorage.setItem('contentType', type);
}
function BindOptions() {
    $('#addContentSelect')
        .on('change', GetSuitedBox);
    SaveTypeInSession('0');

}