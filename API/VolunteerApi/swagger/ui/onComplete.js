$(function () {
    $('#logo').attr("href", "/docs/index");
    $('#logo').text("Volunteer API");

    //var url = $("#input_baseUrl").val().replace("/swagger/api-docs", "/docs/index");
    //$("#input_baseUrl").val(url);
    $("#api_selector").hide();

    $('title').text("Volunteer API docs");

    if ($('#customContent').length == 0) {
        $('#swagger-ui-container').prepend('<div id="customContent">' +
        '<h2 id="customApiHeader">Volunteer Api</h2>' +
        '<p>Volunteer API is a service based on <a href="http://oauth.net/core/1.0a/">Oauth1</a> that you' +
        ' can deal with to get specific data as you need regarding the volunteer app data, ' +
        'and you can register a new user into the volunteer database, whether that user is an organization member or a single volunteer.</p>' +
        '<p>To use Volunteer API you should have a valid consumer subscription so that you have access to a consumer key and a consumer secret ' +
            'that you will be using to authenticate yourself into the Volunteer API to have access to the different secured parts of the app. ' +
            'So to do so, please follow the following four simple and easy steps:</p>' +
        '<ol>' +
            '<li>Get your consumer key and secret by <a href="#">registering</a> yourself as a consumer on Volunteer API</li>' +
            '<li><a>Get access token by posting to "/api/oauth/authorize" passing in your key and secret. This step needs to be done each time you call an API</a></li>' +
            '<li><a>Call any API you need providing the access token you retrieved in the previous step, the access token needs to be valid and unexpired</a></li>' +
            '<li><a>Congratulations, you will get back the results in your request response body if all previous steps and conditions fulfilled</a></li>' +
        '</ol>' +
        '<p>' +
            'For getting more help, please contact us at <a href="mailto:info@vrijwilligersvacaturebank.nl">info@vrijwilligersvacaturebank.nl</a>' +
         '<p>' +
        '</div>');

        // sort categories
        $("#resource_OAuth").prependTo("#resources");

        // operation about
        $('h2>a').each(function () {
            if ($(this).text() == "OAuth")
                $(this).text("Authentication" + ": Operations about consumer authentication");
            else if ($(this).text() == "Master")
                $(this).text("Metadata" + ": Operations about retrieving metadata");
            else if ($(this).text() == "Register")
                $(this).text($(this).text() + ": Operations about new user registration");
            else if ($(this).text() == "Job")
                $(this).text("Jobs" + ": Operations about jobs");
        });

        $('h3>span.path').each(function () {
            var path = $(this).text();
            path = path.toLowerCase().replace('master','metadata');
            $(this).text(path);
        });


        // hide footer 
        $('div.footer').after('<div id="customApiFooter">&copy; Copyright for Volunteer API 2014</div>');
        $('div.footer').hide();
    }
});