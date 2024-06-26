$(document).ready(function () {
    const baseApiUrl = `https://localhost:7032`;
    const btn = $('.traveling-news-btn'); 
    const inputText = $('.traveling-news-text-input');

    inputText.on('input', function () {
        const textValue = inputText.val();
        const isTextLongEnough = textValue.length >= 20;

        btn.prop('disabled', !isTextLongEnough);
        newsText.text(textValue); // ��������� ����� � �������� .traveling-news-text
    })

    btn.click(sendText);

    function sendText() {
        const userId = btn.data('user-id');
        const url = baseApiUrl + "/news/add";
        const text = inputText.val();
        const body ={
            userId: userId,
            text: text
        };

        const promise = $.post(url, body)

        promise.done(function (response) {

            console.log('New News');
            location.reload();
        });

        promise.fail(function (xhr, status, error) {
            console.error(error);
        });
    };
});


