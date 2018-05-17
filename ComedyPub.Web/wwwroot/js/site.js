function openNav() {
    document.getElementById("side").style.width = "150px";
    document.getElementById("main").style.marginLeft = "150px";
    document.body.style.backgroundColor = "rgba(0,0,0,0.4)";
}

function closeNav() {
    document.getElementById("side").style.width = "0";
    document.getElementById("main").style.marginLeft = "0";
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
    let value = $('#addContentSelect').val();

    if (value === '1') {  

        $('#inputContentDiv input').remove();
        let area = $('<textarea>');
        area.addClass('tempInput');
        area.prop('id', 'inputId');
        $('#inputContentDiv')
            .append(area);

    } else {
        $('#inputContentDiv textarea').remove();

        let input = $('<input>');
        input.addClass('tempInput');
        area.prop('id', 'inputId');
        input.prop('type', 'url');

        $('#inputContentDiv')
            .append(input);
    }
}