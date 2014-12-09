
 $(document).ready(function() {
  //hide the modal popup and work on scroll bar starts
  //$('#hideSkill').on('click', function(){
  //  $('#skillBox').modal('hide');
  //})
  //$('#skillBox').on('hide.bs.modal', function (e) {
  //  $('body').css('overflow-y', 'hidden');
  //});
  //$('#suggestSkillBox').on('hide.bs.modal', function (e) {
  //  $('body').css('overflow-y', 'auto');
  //});
  //hide the modal popup and work on scroll bar ends
  
   //hide the modal popup and work on scroll bar starts -diploma
  //$('#hideDiploma').on('click', function(){
  //  $('#diplomaBox').modal('hide');
  //})
  //$('#diplomaBox').on('hide.bs.modal', function (e) {
  //  $('body').css('overflow-y', 'hidden');
  //});
  //$('#suggestDiplomaBox').on('hide.bs.modal', function (e) {
  //  $('body').css('overflow-y', 'auto');
  //});
  //hide the modal popup and work on scroll bar ends
  

  $('#tabs > div').hide(); // hide all child divs
  $('#tabs div:first').show(); // show first child dive
  $('#tabsnav li:first').addClass('active');

  $('.menu-internal').click(function(){
   $('#tabsnav li').removeClass('active');
   var currentTab = $(this).attr('href');
   $('#tabsnav li a[href="'+currentTab+'"]').parent().addClass('active');
   $('#tabs > div').hide();
   $(currentTab).show();
   return false;
  });
  // Create a bookmarkable tab link
  hash = window.location.hash;
  elements = $('a[href="'+hash+'"]'); // look for tabs that match the hash
  if (elements.length === 0) { // if there aren't any, then
   $("ul.tabs li:first").addClass("active").show(); // show the first tab
  } else { elements.click(); } // else, open the tab in the hash
 });


/*
date time picker
*/
$(document).ready(function() {
    $('#datetimepicker8').datetimepicker({
      pickTime: false
    });
    $('#datetimepicker9').datetimepicker({
      pickTime: false
    });

    $("#datetimepicker8").on("dp.change", function (e) {
        //debugger;
       $('#datetimepicker9').data("DateTimePicker").setMinDate(e.date);

    });

    $("#datetimepicker9").on("dp.change",function (e) {
       $('#datetimepicker8').data("DateTimePicker").setMaxDate(e.date);
    });



    $('#btnPostJob').click(
    function () {
        debugger;
        var _questionsJSON = PrepareQuestionsJSON();
        $('#hdnQuestions').val(_questionsJSON);

    });


});

/*popover for job dropdown */
var element_job = "<span style='text-align:left; width:250px;color: #7c7c7a;font-family: Helvetica,Arial,sans-serif;font-size: 13px;'>Ut wisi enim ad minim veniam, quis nostrud exerci tation ullamcorper suscipit lobortis nisl ut aliquip ex ea commodo consequat. Duis autem vel eum iriure dolor in hendrerit in vulputate velit esse molestie cons.</span>";
$("#job-type").popover({
      title: "Job type",
      trigger: "focus"
});
$( "#job-type" ).focus(function(event) {
    event.preventDefault();
    $("#job-type").popover('show');
    $("#jobs div.popover-content").replaceWith(element_job);
    event.stopPropagation();
});
$( "#job-type" ).focusout(function() {
    event.preventDefault();
    $("#job-type").popover('hide');
    event.stopPropagation();
});

/*popover for title */
var element_title1 = " ";
$("#form-control-weight").popover({
      title: "What's the title?",
      trigger: "focus"
});
$( "#form-control-weight" ).focus(function(event) {
    event.preventDefault();
    event.stopPropagation();
    $("#title div.popover-content").replaceWith(element_title);
    $("#form-control-weight").popover('show');
});
$( "#form-control-weight" ).focusout(function() {
    event.preventDefault();
    event.stopPropagation();
    $("#form-control-weight").popover('hide');
});
/*popover for textarea to descrbe the work to be done */
var element_describe = "<p style='text-align:left; width:250px;color: #7c7c7a;font-family: Helvetica,Arial,sans-serif;font-size: 13px;'>Provide an overview of your needs and what you’re looking for in the right volunteer. Add specifics here as needed, or use the Additional Information boxes below.</p>";
$("#text-content").popover({
      title: "Describe the work?",
      trigger: "focus"
});
$( "#text-content" ).focus(function(event) {
    event.preventDefault();
    event.stopPropagation();
    $("#describe-work div.popover-content").replaceWith(element_describe);
    $("#text-content").popover('show');
});
$( "#text-content" ).focusout(function() {
    event.preventDefault();
    event.stopPropagation();
    $("#text-content").popover('hide');
});
/* skills popover */
$( document ).ready(function() {
  var size = 120;
  var pointer = $("#skills-popover").find("input:last");
  pointer.attr( "id", "skill-text" );
  pointer.attr( "size", size );
  pointer.parent().attr("id", "skills");

  var element_skills = "<p style='text-align:left; width:250px;color: #7c7c7a;font-family: Helvetica,Arial,sans-serif;font-size: 13px;'>Lorem ipsum dolor sit amet, consectetuer adipiscing elit, sed diam nonummy nibh euismod tincidunt ut laoreet dolore magna aliquam erat volutpat. Ut wisi enim ad minim veniam.</p>";
  $("#skill-text").popover({
        title: "What skills are needed?",
        trigger: "focus"
  });
  $( "#skill-text" ).focus(function(event) {
      event.preventDefault();
      event.stopPropagation();
      pointer.attr( "size", size);
      $("#skills div.popover-content").replaceWith(element_skills);
      $("#skill-text").popover('show');
  });
  $( "#skill-text" ).focusout(function(event) {
      event.preventDefault();
      event.stopPropagation();
      $("#skill-text").popover('hide');
  });
});

/* Diplomas popover*/
$( document ).ready(function() {
  var pointer = $("#diploma-popover").find("input:last");
  pointer.attr( "id", "diploma-text" );
  pointer.attr( "size", "120" );
  pointer.parent().attr("id", "diplomas");

  var element_diploma = "<p style='text-align:left; width:250px;color: #7c7c7a;font-family: Helvetica,Arial,sans-serif;font-size: 13px;'>Lorem ipsum dolor sit amet, consectetuer adipiscing elit, sed diam nonummy nibh euismod tincidunt ut laoreet dolore magna aliquam erat volutpat. Ut wisi enim ad minim veniam.</p>";
  $("#diploma-text").popover({
        title: "What Diplomas/Certificates are needed?",
        trigger: "focus"
  });
  $( "#diploma-text" ).focus(function(event) {
      event.preventDefault();
      event.stopPropagation();
      pointer.attr( "size", "120" );
      $("#diplomas div.popover-content").replaceWith(element_diploma);
      $("#diploma-text").popover('show');
  });
  $( "#diploma-text" ).focusout(function(event) {
      event.preventDefault();
      event.stopPropagation();
      $("#diploma-text").popover('hide');
  });
});


/* days of week popover*/
$( document ).ready(function() {
  var pointer = $("#dow-popover").find("input:last");
  pointer.attr( "id", "dow-text" );
  pointer.attr( "size", "120" );
  pointer.parent().attr("id", "dow");

  var element_dow = "<p style='text-align:left; width:250px;color: #7c7c7a;font-family: Helvetica,Arial,sans-serif;font-size: 13px;'>Lorem ipsum dolor sit amet, consectetuer adipiscing elit, sed diam nonummy nibh euismod tincidunt ut laoreet dolore magna aliquam erat volutpat. Ut wisi enim ad minim veniam.</p>";
  $("#dow-text").popover({
        title: "Days of week",
        trigger: "focus"
  });
  $( "#dow-text" ).focus(function(event) {
      event.preventDefault();
      event.stopPropagation();
      pointer.attr( "size", "120" );
      $("#dow div.popover-content").replaceWith(element_dow);
      $("#dow-text").popover('show');
  });
  $( "#dow-text" ).focusout(function(event) {
      event.preventDefault();
      event.stopPropagation();
      $("#dow-text").popover('hide');
  });
});
/* language popover*/
$( document ).ready(function() {
  var pointer = $("#language-popover").find("input:last");
  pointer.attr( "id", "language-text" );
  pointer.attr( "size", "120" );
  pointer.parent().attr("id", "language");

  var element_language = "<p style='text-align:left; width:250px;color: #7c7c7a;font-family: Helvetica,Arial,sans-serif;font-size: 13px;'>Lorem ipsum dolor sit amet, consectetuer adipiscing elit, sed diam nonummy nibh euismod tincidunt ut laoreet dolore magna aliquam erat volutpat. Ut wisi enim ad minim veniam.</p>";
  $("#language-text").popover({
        title: "Language",
        trigger: "focus"
  });
  $( "#language-text" ).focus(function(event) {
      event.preventDefault();
      event.stopPropagation();
      pointer.attr( "size", "120" );
      $("#language div.popover-content").replaceWith(element_language);
      $("#language-text").popover('show');
  });
  $( "#language-text" ).focusout(function(event) {
      event.preventDefault();
      event.stopPropagation();
      $("#language-text").popover('hide');
  });
});
/* screening popover*/
$( document ).ready(function() {
  var pointer = $("#screening-popover").find("input:last");
  pointer.attr( "id", "screening-text" );
  pointer.attr( "size", "120" );
  pointer.parent().attr("id", "screening");

  var element_screening = "<p style='text-align:left; width:250px;color: #7c7c7a;font-family: Helvetica,Arial,sans-serif;font-size: 13px;'>Lorem ipsum dolor sit amet, consectetuer adipiscing elit, sed diam nonummy nibh euismod tincidunt ut laoreet dolore magna aliquam erat volutpat. Ut wisi enim ad minim veniam.</p>";
  $("#screening-text").popover({
        title: "Screening questions",
        trigger: "focus"
  });
  $( "#screening-text" ).focus(function(event) {
      event.preventDefault();
      event.stopPropagation();
      pointer.attr( "size", "120" );
      $("#screening div.popover-content").replaceWith(element_screening);
      $("#screening-text").popover('show');
  });
  $( "#screening-text" ).focusout(function(event) {
      event.preventDefault();
      event.stopPropagation();
      $("#screening-text").popover('hide');
  });
});

/*  Start and end date*/
var element_date = "<p style='text-align:left; width:250px;color: #7c7c7a;font-family: Helvetica,Arial,sans-serif;font-size: 13px;'>Quis nostrud exerci tation ullamcorper suscipit lobortis nisl ut aliquip ex ea commodo consequat.</p>";
$("#datepicker1").popover({
      title: "Select start date",
      trigger: "focus"
});
$( "#datepicker1" ).focus(function(event) {
    $("#datepicker div.popover-content").replaceWith(element_date);
    $("#datepicker1").popover('show');
});
$("#datepicker2").popover({
      title: "Select end date",
      trigger: "focus"
});
$( "#datepicker2" ).focus(function(event) {
    $("#datepicker div.popover-content").replaceWith(element_date);
    $("#datepicker2").popover('show');
});

/* checkboxes for time comittment on hover*/
var element_time_comittment = "<p style='text-align:left; width:250px;color: #7c7c7a;font-family: Helvetica,Arial,sans-serif;font-size: 13px;'>Quis nostrud exerci tation ullamcorper suscipit lobortis nisl ut aliquip ex ea commodo consequat.</p>";
$("#time-checkbox").popover({
      title: "Time comittment",
      trigger: "hover"
});
$( "#time-checkbox" ).hover(function(event) {
    event.preventDefault();
    event.stopPropagation();
    $(".check-label div.popover-content").replaceWith(element_time_comittment);
    $("#time-checkbox").popover('show');
});

/* checkboxes for schedule on hover */
var element_schedule = "<p style='text-align:left; width:250px;color: #7c7c7a;font-family: Helvetica,Arial,sans-serif;font-size: 13px;'>Quis nostrud exerci tation ullamcorper suscipit lobortis nisl ut aliquip ex ea commodo consequat.</p>";
$("#schedule-checkbox").popover({
      title: "Schedule",
      trigger: "hover"
});
$( "#schedule-checkbox" ).hover(function(event) {
    event.preventDefault();
    event.stopPropagation();
    $(".check-label div.popover-content").replaceWith(element_schedule);
    $("#schedule-checkbox").popover('show');
});

/* checkboxes for schedule on hover */
var element_appropriate = "<p style='text-align:left; width:250px;color: #7c7c7a;font-family: Helvetica,Arial,sans-serif;font-size: 13px;'>Duis vitae orci purus, quis euismod augue. Ut wisi enim ad minim veniam, quis nostrud exerci tation ullamcorper suscipit lobortis nisl ut aliquip ex ea commodo consequat.</p>";
$("#appropriate-checkbox").popover({
      title: "Appropriate for",
      trigger: "hover"
});
$( "#appropriate-checkbox" ).hover(function(event) {
    event.preventDefault();
    event.stopPropagation();
    $(".check-label div.popover-content").replaceWith(element_appropriate);
    $("#appropriate-checkbox").popover('show');
});

/* checkboxes for IVO on hover */
var element_IVO = "<p style='text-align:left; width:250px;color: #7c7c7a;font-family: Helvetica,Arial,sans-serif;font-size: 13px;'>Morbi lorem arcu, aliquet sed feugiat et, posuere non elit fusce sollicitudin.  Nunc at in hendrerit in vulputate, imperdiet fringilla.</p>";
$("#IVO-checkbox").popover({
      title: "International volunteer option",
      trigger: "hover"
});
$( "#IVO-checkbox" ).hover(function(event) {
    event.preventDefault();
    event.stopPropagation();
    $(".check-label div.popover-content").replaceWith(element_IVO);
    $("#IVO-checkbox").popover('show');
});

/* checkboxes for extra on hover */
var element_extra = "<p style='text-align:left; width:250px;color: #7c7c7a;font-family: Helvetica,Arial,sans-serif;font-size: 13px;'>Aliquam mauris felis, viverra in mattis vitae adipiscing elit, sed diam nonummy nibh.  Euismod tincidunt ut laoreet dolore magna aliquam erat volutpat. Ut wisi lobortis nisl ut aliquip ex ea commodo consequat.</p>";
$("#extra-checkbox").popover({
      title: "Extra details",
      trigger: "hover"
});
$( "#extra-checkbox" ).hover(function(event) {
    event.preventDefault();
    event.stopPropagation();
    $(".check-label div.popover-content").replaceWith(element_extra);
    $("#extra-checkbox").popover('show');
});

/* title popover */
var element_title = "<p style='text-align:left; width:250px;color: #7c7c7a;font-family: Helvetica,Arial,sans-serif;font-size: 13px;'>Announce what you’re looking for.</p>";
$("#form-control-weight").popover({
      title: "What's the title?",
      trigger: "focus"
});
$( "#form-control-weight" ).focus(function(event) {
    event.preventDefault();
    event.stopPropagation();
    $("#title div.popover-content").replaceWith(element_title);
    $("#form-control-weight").popover('show');
});
$( "#form-control-weight" ).focusout(function() {
    event.preventDefault();
    event.stopPropagation();
    $("#form-control-weight").popover('hide');
});


    /* adding extra questions */
$( "#skills" ).click(function() {
  $( this ).next( "ul" ).toggle();
  if($(this).is('.btn-primary')){
        $(this).removeClass('btn-primary').addClass('btn-danger');
        $( this ).text("Hide Skills / Certificates")
    }else{
        $(this).removeClass('btn-danger').addClass('btn-primary');
        $( this ).text("Add Skills / Certificates")
        //Do Stop
    }
});
$( "#time" ).click(function() {
  $( this ).next( "ul" ).toggle();
  if($(this).is('.btn-primary')){
        $(this).removeClass('btn-primary').addClass('btn-danger');
        $( this ).text("Hide Time Commitments")
    }else{
        $(this).removeClass('btn-danger').addClass('btn-primary');
        $( this ).text("Add Time Commitments")
        //Do Stop
    }
});
$( "#miscleaneous" ).click(function() {
  $( this ).next( "ul" ).toggle();
  if($(this).is('.btn-primary')){
      $(this).removeClass('btn-primary').addClass('btn-danger');
      $( this ).text("Hide Additional Preferences")
    }else{
      $(this).removeClass('btn-danger').addClass('btn-primary');
      $( this ).text("Add Additional Preferences")
      //Do Stop
    }
});

$( "#location" ).click(function() {
  $( this ).next( "ul" ).toggle();
  if($(this).is('.btn-primary')){
      $(this).removeClass('btn-primary').addClass('btn-danger');
      $( this ).text("Hide Job Location");
    }else{
      $(this).removeClass('btn-danger').addClass('btn-primary');
      $( this ).text("Add Job Location");
      //Do Stop
    }
});

var address_element = "<div class='border-address col-sm-7'>" +   
                            "<button type='button' class='close pull-right' aria-hidden='true' onclick='closeAddress()'>&times;</button>" +
                            "<label >City</label>" +
                            "<input type='text' class='form-control' id='form-control-weight' for='city' id='form-text-control'>" +
                            "<div class='row'>" +
                              "<div id='extra-space-label'>" +
                              "</div>" +
                            "</div>" +
                              "<label >Country</label>" +
                              "<select class='form-control'>" +
                                "<option value='Ipsum'>Afghanistan</option>" +
                                "<option value='Consectetur'>Akrotiri</option>" +
                                "<option value='Ipsum'>Albania</option>" +
                                "<option value='Consectetur'>Algeria</option>" +
                                "<option value='Ipsum'>Angola</option>" +
                                "<option value='Consectetur'>Antarctica</option>" +
                                "<option value='Ipsum'>Antigua and Barbuda</option>" +
                                "<option value='Consectetur'>Argentina</option>" +
                                "<option value='Ipsum'>Australia</option>" +
                                "<option value='Consectetur'>Austria</option>" +
                                "<option value='Ipsum'>Bahamas, The</option>" +
                                "<option value='Consectetur'>Bangladesh</option>" +
                                "<option value='Ipsum'>Bassas da India</option>" +
                                "<option value='Consectetur'>Belarus</option>" +
                                "<option value='Ipsum'>Belgium</option>" +
                                "<option value='Consectetur'>Bermuda</option>" +
                                "<option value='Ipsum'>Bhutan</option>" +
                                "<option value='Consectetur'>Brazil</option>" +
                                "<option value='Ipsum'>British Indian Ocean Territory</option>" +
                                "<option value='Consectetur'>British Virgin Islands</option>" +
                                "<option value='Ipsum'>Bulgaria</option>" +
                                "<option value='Consectetur'>Burma</option>" +
                                "<option value='Ipsum'>Burundi</option>" +
                                "<option value='Consectetur'>Cambodia</option>" +
                                "<option value='Ipsum'>Cameroon</option>" +
                                "<option value='Consectetur'>Canada</option>" +
                                "<option value='Ipsum'>China</option>" +
                                "<option value='Consectetur'>Cocos (Keeling) Islands</option>" +
                                "<option value='Ipsum'>Colombia</option>" +
                                "<option value='Consectetur'>Comoros</option>" +
                                "<option value='Ipsum'>Congo, Democratic Republic of the</option>" +
                                "<option value='Consectetur'>Congo, Republic of the</option>" +
                                "<option value='Ipsum'>Cook Islands</option>" +
                                "<option value='Consectetur'>Cuba</option>" +
                                "<option value='Ipsum'>Cyprus</option>" +
                                "<option value='Consectetur'>Denmark</option>" +
                                "<option value='Ipsum'>Dominican Republic</option>" +
                                "<option value='Consectetur'>Ecuador</option>" +
                                "<option value='Ipsum'>Egypt</option>" +
                                "<option value='Consectetur'>Ethiopia</option>" +
                                "<option value='Ipsum'>Finland</option>" +
                                "<option value='Consectetur'>France</option>" +
                                "<option value='Ipsum'>Georgia</option>" +
                                "<option value='Consectetur'>Germany</option>" +
                                "<option value='Ipsum'>Greece</option>" +
                                "<option value='Consectetur'>Greenland</option>" +
                                "<option value='Ipsum'>Guinea</option>" +
                                "<option value='Consectetur'>Holy See (Vatican City)</option>" +
                                "<option value='Ipsum'>Hong Kong</option>" +
                                "<option value='Consectetur'>Iceland</option>" +
                                "<option value='Ipsum'>India</option>" +
                                "<option value='Consectetur'>Indonesia</option>" +
                                "<option value='Ipsum'>Iran</option>" +
                                "<option value='Consectetur'>Iraq</option>" +
                                "<option value='Ipsum'>Ireland</option>" +
                                "<option value='Consectetur'>Israel</option>" +
                                "<option value='Ipsum'>Italy</option>" +
                                "<option value='Consectetur'>Jamaica</option>" +
                                "<option value='Ipsum'>Japan</option>" +
                                "<option value='Consectetur'>Jersey</option>" +
                                "<option value='Ipsum'>Kazakhstan</option>" +
                                "<option value='Consectetur'>Kenya</option>" +
                                "<option value='Ipsum'>Korea</option>" +
                                "<option value='Consectetur'>Kuwait</option>" +
                                "<option value='Ipsum'>Laos</option>" +
                                "<option value='Consectetur'>Lebanon</option>" +
                                "<option value='Ipsum'>Liberia</option>" +
                                "<option value='Consectetur'>Macau</option>" +
                                "<option value='Ipsum'>Malaysia</option>" +
                                "<option value='Consectetur'>Maldives</option>" +
                                "<option value='Ipsum'>Mauritius</option>" +
                                "<option value='Consectetur'>Mexico</option>" +
                                "<option value='Ipsum'>Mozambique</option>" +
                                "<option value='Consectetur'>Namibia</option>" +
                                "<option value='Ipsum'>Nepal</option>" +
                                "<option value='Consectetur' selected='selected'>Netherlands</option>" +
                                "<option value='Ipsum'>New Zealand</option>" +
                                "<option value='Consectetur'>Norway</option>" +
                                "<option value='Ipsum'>Oman</option>" +
                                "<option value='Consectetur'>Pakistan</option>" +
                                "<option value='Ipsum'>Peru</option>" +
                                "<option value='Consectetur'>Philippines</option>" +
                                "<option value='Ipsum'>Poland</option>" +
                                "<option value='Consectetur'>Portugal</option>" +
                                "<option value='Ipsum'>Qatar</option>" +
                                "<option value='Consectetur'>Romania</option>" +
                                "<option value='Ipsum'>Russia</option>" +
                                "<option value='Consectetur'>Saudi Arabia</option>" +
                                "<option value='Ipsum'>Sierra Leone</option>" +
                                "<option value='Consectetur'>Singapore</option>" +
                                "<option value='Ipsum'>Solomon Islands</option>" +
                                "<option value='Consectetur'>Somalia</option>" +
                                "<option value='Ipsum'>South Africa</option>" +
                                "<option value='Consectetur'>Spain</option>" +
                                "<option value='Ipsum'>Sri Lanka</option>" +
                                "<option value='Consectetur'>Sweden</option>" +
                                "<option value='Ipsum'>Switzerland</option>" +
                                "<option value='Consectetur'>Syria</option>" +
                                "<option value='Ipsum'>Taiwan</option>" +
                                "<option value='Consectetur'>Thailand</option>" +
                                "<option value='Ipsum'>Turkey</option>" +
                                "<option value='Consectetur'>Uganda</option>" +
                                "<option value='Ipsum'>Ukraine</option>" +
                                "<option value='Consectetur'>United Arab Emirates</option>" +
                                "<option value='Ipsum'>United Kingdom</option>" +
                                "<option value='Consectetur'>United States</option>" +
                                "<option value='Ipsum'>Venezuela</option>" +
                                "<option value='Consectetur'>Vietnam</option>" +
                                "<option value='Ipsum'>Yemen</option>" +
                                "<option value='Consectetur'>Zambia</option>" +
                                "<option value='Ipsum'>Zimbabwe</option>" +
                              "</select>" +
                              "<div class='row'>" +
                                "<div id='extra-space-label'>" +
                                "</div>" +
                              "</div>" +
                              "<label >Zip code</label>" +
                              "<input type='text' class='form-control' id='form-control-weight' for='inserting address' id='form-text-control' placeholder='Zip code'>" +
                              "<div class='row'>" +
                                "<div id='extra-space-label'>" +
                                "</div>" +
                              "</div>" +
                            "</div>";
function addNewAddress(){
  $("ul#address li").append( address_element );
}
function closeAddress(){
 $("ul#address li div:last-child").remove(); 
}

/*header dropdown selection */
$("#username .dropdown-menu li a").click(function(){
  var selText = $(this).text();
  $( this ).addClass("active"); 
  $(this).parents('.dropdown.pull-right').find('.dropdown-toggle').html(selText+' <span class="caret"></span>');
});
/* to add css */
$('#username .dropdown-menu li a').click(function() {
    var style = {
              backgroundColor: "#ffffff",
              borderRadius: "4px",
              color: "#4C4559",
              fontWeight: "600"
    }
    var style_empty = {
              backgroundColor: "",
              borderRadius: "",
              color: "",
              fontWeight: ""         
    }
    if($('#dropdown').data('open')) {
        $('#dropdown').data('open', false);
    } else
        $('#dropdown').data('open', true);
        $("#username .dropdown-menu li a").css(style_empty);
        $(this).css(style);

});
$( document ).ready(function() {
  var style = {
      backgroundColor: "#ffffff",
      borderRadius: "4px",
      color: "#4C4559",
      fontWeight: "600"
  }
  $("#username .dropdown-menu li #tab-header-1").css(style);
});


//Describe the work to be done data modal to count the number of characters
$("#text-content").keyup(function() {
  var text  = $(this).val();
  $('#text-content-pop').val(text);
  $('#text-content-count').text($(this).val().length);
  $('#text-content-count-pop').text($(this).val().length);
});
$("#text-content-pop").keyup(function() {
  var text  = $(this).val();
  $('#text-content').val(text);
  $('#text-content-count-pop').text(text.length);
  $('#text-content-count').text(text.length);
});

$(".dropdown-menu li a").click(function(){
  var selText = $(this).text();
  $(this).parents('.btn-group').find('.dropdown-toggle').html(selText+' <b class="caret"></b>');
});



var language_set = [{'value':'Afrikaans','text':'Afrikaans'}, {'value':'Albanian','text':'Albanian'}, {'value':'Arabic','text':'Arabic'}, 
                  {'value':'Armenian','text':'Armenian'}, {'value':'Azerbaijani','text':'Azerbaijani'}, {'value':'Basque','text':'Basque'},
                  {'value':'Belarusian','text':'Belarusian'}, {'value':'Bengali','text':'Bengali'}, {'value':'Bosnian','text':'Bosnian'}, 
                  {'value':'Bulgarian','text':'Bulgarian'}, {'value':'Catalan','text':'Catalan'}, {'value':'Cebuano','text':'Cebuano'}, 
                  {'value':'Chinese','text':'Chinese'}, {'value':'Danish','text':'Danish'}, {'value':'Dutch','text':'Dutch'}, 
                  {'value':'English','text':'English'}, {'value':'Esperanto','text':'Esperanto'}, {'value':'Estonian','text':'Estonian'},
                  {'value':'Filipino','text':'Filipino'}, {'value':'French','text':'French'}, {'value':'Georgian','text':'Georgian'}, 
                  {'value':'German','text':'German'}, {'value':'Greek','text':'Greek'}, {'value':'Hausa','text':'Hausa'}, 
                  {'value':'Hebrew','text':'Hebrew'}, {'value':'Hindi','text':'Hindi'}, {'value':'Hungarian','text':'Hungarian'},
                  {'value':'Indonesian','text':'Indonesian'}, {'value':'Irish','text':'Irish'}, {'value':'Italian','text':'Italian'},
                  {'value':'Japanese','text':'Japanese'}, {'value':'Korean','text':'Korean'}, {'value':'Lao','text':'Lao'},
                  {'value':'Latin','text':'Latin'}, {'value':'Mongolian','text':'Mongolian'}, {'value':'Norwegian','text':'Norwegian'},
                  {'value':'Persian','text':'Persian'}, {'value':'Portuguese','text':'Portuguese'}, {'value':'Punjabi','text':'Punjabi'},
                  {'value':'Romanian','text':'Romanian'}, {'value':'Russian','text':'Russian'}, {'value':'Serbian','text':'Serbian'},
                  {'value':'Spanish','text':'Spanish'}, {'value':'Swedish','text':'Swedish'}, {'value':'Thai','text':'Thai'},
                  {'value':'Turkish','text':'Turkish'}, {'value':'Ukrainian','text':'Ukrainian'}, {'value':'Urdu','text':'Urdu'},
                  {'value':'Vietnamese','text':'Vietnamese'}, {'value':'Welsh','text':'Welsh'}, {'value':'Yoruba','text':'Yoruba'},
                  {'value':'Zulu','text':'Zulu'}];

$('#language-tag').tagsinput({
  itemValue: 'value',
  itemText: 'text',
  typeahead: {
    source: language_set,
    sorter: function (items) {
        return items.sort();
    }
  }
});

$("#language-tag").next().children('input').attr("onkeypress", "doNothing()");

function updateValueLanCheck(){
    var listOfLan = [], listofLanObject = {};
    var lstLanguages = "";


    $('input:checkbox.ChkLanguage').each(function (i) {
        if ($(this).is(":checked")) {
            listofLanObject = { 'text': ' ', 'value': ' ' };
            //getting current node elements
            currentnode = $(this).val();
            listofLanObject.text = currentnode;
            listofLanObject.value = currentnode;
            listOfLan.push(listofLanObject);
            var id = $(this).data('languageid');
            if (lstLanguages == "") {
                lstLanguages = id;
            }
            else {
                lstLanguages = lstLanguages + "," + id;
            }
        }
    });
    $('#LanguageIDs').val(lstLanguages);

  $('#language-tag').tagsinput('removeAll');
  $("#language-tag").tagsinput("refresh");
  for(i = 0 ; i < listOfLan.length ; i++){
    $("#language-tag").tagsinput('add', listOfLan[i]);
  }
  $("#language-tag").next().children('input').attr("placeholder", " ");
}

//Adding input tag from dropdown
$('#language-tag').on('itemAdded', function(event) {
   var lengthInputTag = $("#language-tag").next().children().length;
    if (lengthInputTag == 1){
        $("#language-tag").next().children('input').attr("placeholder", "Add language");   
    } else if (lengthInputTag > 1){
      $("#language-tag").next().children('input').attr("placeholder", " ");
    }
});

$('#language-tag').on('itemRemoved', function(event) {
  var lengthInputTag = $("#language-tag").next().children().length;
  if (lengthInputTag == 1){
      $("#language-tag").next().children('input').attr("placeholder", "Add language");   
  } 
});

function updateValueLanText(){  
  $("#language-tag").tagsinput("refresh");
  var tagsValue = $("#language-tag").val();
  var tagsList = tagsValue.split(",");
  console.log(tagsList);
  for( i=1 ; i <= 52 ; i++){
        $("#lan" + i + "").prop("checked", false);
  }
  for( i=1 ; i <= 52 ; i++){
    for( j = 0 ; j < tagsList.length ; j++ ){
      if($("#lan" + i + "").val() === tagsList[j]){
        $("#lan" + i + "").prop("checked", true);
      }
    }
  }
}


//Source for Days of week
var dowtag_set = [{'value':'All Weekdays - Full day','text':'All Weekdays - Full day'}, {'value':'Weekends - Full day','text':'Weekends - Full day'}, {'value':'Monday - Full day','text':'Monday - Full day'}, {'value':'Tuesday - Full day','text':'Tuesday - Full day'}, {'value':'Wednesday - Full day','text':'Wednesday - Full day'}, {'value':'Thursday - Full day','text':'Thursday - Full day'},
                  {'value':'Friday - Full day','text':'Friday - Full day'}, {'value':'Saturday - Full day','text':'Saturday - Full day'}, {'value':'Sunday - Full day','text':'Sunday - Full day'}, {'value':'All Weekdays - Morning','text':'All Weekdays - Morning'}, {'value':'Weekends - Morning','text':'Weekends - Morning'}, {'value':'Monday - Morning','text':'Monday - Morning'}, 
                  {'value':'Tuesday - Morning','text':'Tuesday - Morning'}, {'value':'Wednesday - Morning','text':'Wednesday - Morning'}, {'value':'Thursday - Morning','text':'Thursday - Morning'}, {'value':'Friday - Morning','text':'Friday - Morning'}, {'value':'Saturday - Morning','text':'Saturday - Morning'}, {'value':'Sunday - Morning','text':'Sunday - Morning'},
                  {'value':'All Weekdays - Afternoon','text':'All Weekdays - Afternoon'}, {'value':'Weekends - Afternoon','text':'Weekends - Afternoon'}, {'value':'Monday - Afternoon','text':'Monday - Afternoon'}, {'value':'Tuesday - Afternoon','text':'Tuesday - Afternoon'}, {'value':'Wednesday - Afternoon','text':'Wednesday - Afternoon'}, {'value':'Thursday - Afternoon','text':'Thursday - Afternoon'}, 
                  {'value':'Friday - Afternoon','text':'Friday - Afternoon'}, {'value':'Saturday - Afternoon','text':'Saturday - Afternoon'}, 
                  {'value':'Sunday - Afternoon','text':'Sunday - Afternoon'}, {'value':'All Weekdays - Evening','text':'All Weekdays - Evening'}, 
                  {'value':'Weekends - Evening','text':'Weekends - Evening'}, {'value':'Monday - Evening','text':'Monday - Evening'},
                  {'value':'Tuesday - Evening','text':'Tuesday - Evening'}, {'value':'Wednesday - Evening','text':'Wednesday - Evening'},
                  {'value':'Thursday - Evening','text':'Thursday - Evening'}, {'value':'Friday - Evening','text':'Friday - Evening'},
                  {'value':'Saturday - Evening','text':'Saturday - Evening'}, {'value':'Saturday - Evening','text':'Saturday - Evening'},
                  {'value':'Sunday - Evening','text':'Sunday - Evening'}, {'value':'All Weekdays - Late Night','text':'All Weekdays - Late Night'},
                  {'value':'Weekends - Late Night','text':'Weekends - Late Night'}, {'value':'Monday - Late Night','text':'Monday - Late Night'},                  
                  {'value':'Tuesday - Late Night','text':'Tuesday - Late Night'}, {'value':'Wednesday - Late Night','text':'Wednesday - Late Night'},
                  {'value':'Thursday - Late Night','text':'Thursday - Late Night'}, {'value':'Friday - Late Night','text':'Friday - Late Night'},
                  {'value':'Saturday - Late Night','text':'Saturday - Late Night'}, {'value':'Sunday - Evening','text':'Sunday - Evening'}
                  ];

$('#dow-tag').tagsinput({
  itemValue: 'value',
  itemText: 'text',
  typeahead: {
    source: dowtag_set,
    sorter: function (items) {
        return items.sort();
    }
  }
});

/*Adding method to prevent enter from being click*/
$("#dow-tag").next().children('input').attr("onkeypress", "doNothing()");

function updateValueDowCheck(){
    var listOfDow = [], listofDowObject = {};
    var lstDayOfWeeks = "";
    $('.dvDaysOfWeek input:checkbox').each(function (i) {
        if ($(this).is(":checked")) {
            listofDowObject = { 'text': ' ', 'value': ' ' };
            //getting current node elements
            currentnode = $(this).val();
            listofDowObject.text = currentnode;
            listofDowObject.value = currentnode;
            listOfDow.push(listofDowObject);

            var id = $(this).val();
            if (lstDayOfWeeks == "") {
                lstDayOfWeeks = id;
            }
            else {
                lstDayOfWeeks = lstDayOfWeeks + "," + id;
            }
        }
    });
    
    $('#DayOfWeekIDs').val(lstDayOfWeeks);
  $('#dow-tag').tagsinput('removeAll');
  $("#dow-tag").tagsinput("refresh");
  for(i = 0; i < listOfDow.length ; i++){
    $("#dow-tag").tagsinput('add', listOfDow[i]);
  }
   $("#dow-tag").next().children('input').attr("placeholder", " ");
}

//Adding input tag from dropdown
$('#dow-tag').on('itemAdded', function(event) {
   var lengthInputTag = $("#dow-tag").next().children().length;
    if (lengthInputTag == 1){
        $("#dow-tag").next().children('input').attr("placeholder", "Add days of the week");   
    } else if (lengthInputTag > 1){
      $("#dow-tag").next().children('input').attr("placeholder", " ");
    }
});

/* On Removing tags */
$('#dow-tag').on('itemRemoved', function(event) {
  var lengthInputTag = $("#dow-tag").next().children().length;
  if (lengthInputTag == 1){
      $("#dow-tag").next().children('input').attr("placeholder", "Add days of the week");   
  } 
});

function updateValueDowText(){
  $("#dow-tag").tagsinput("refresh");
  var tagsValue = $("#dow-tag").val();
  var tagsList = tagsValue.split(",");
  console.log(tagsList);
  for( i=1 ; i <= 49 ; i++){
        $("#dow" + i + "").prop("checked", false);
  }
  for( i=1 ; i <= 49 ; i++){
    for( j = 0 ; j < tagsList.length ; j++ ){
      if($("#dow" + i + "").val() === tagsList[j]){
        $("#dow" + i + "").prop("checked", true);
      }
    }
  }
}


//Key-value pair value to work 
var skills_set = [{'value':'Answering Telephones','text':'Answering Telephones'}, {'value':'Accounting','text':'Accounting'}, {'value':'Administration','text':'Administration'}, {'value':'Business Correspondence','text':'Business Correspondence'}, {'value':'Client Relations','text':'Client Relations'}, {'value':'Communication','text':'Communication'},
                  {'value':'Crowd Control','text':'Crowd Control'}, {'value':'Crime & Safety','text':'Crime & Safety'}, {'value':'Customer Service','text':'Customer Service'}, {'value':'Clerical','text':'Clerical'}, {'value':'Document Management','text':'Document Management'}, {'value':'Disaster Relief','text':'Disaster Relief'}, 
                  {'value':'Document Management','text':'Document Management'}, {'value':'Event Coordination','text':'Event Coordination'}, {'value':'Employee Relations','text':'Employee Relations'}, {'value':'Legal Familiarity','text':'Legal Familiarity'}, {'value':'Meeting Planning','text':'Meeting Planning'}, {'value':'Office Administration','text':'Office Administration'},
                  {'value':'Organizational Skills','text':'Organizational Skills'}, {'value':'Public Relations','text':'Public Relations'}, {'value':'Public Speaking','text':'Public Speaking'}, {'value':'People Management','text':'People Management'}, {'value':'Receptionist','text':'Receptionist'}, {'value':'Stenography','text':'Stenography'}, 
                  {'value':'Travel Arrangements','text':'Travel Arrangements'}, {'value':'Word Processing','text':'Word Processing'}, {'value':'Written Communication','text':'Written Communication'}];
$('#skill-tag').tagsinput({
  itemValue: 'value',
  itemText: 'text',
  typeahead: {
    source: skills_set,
    sorter: function (items) {
        return items.sort();
    }
  },
});
/*Adding method to prevent enter from being click*/
$("#skill-tag").next().children('input').attr("onkeypress", "doNothing()");

function updateValueSkillCheck(){
    var listOfSkill = [], listofSkillsObject = {};
    var lstSkillIDs = "";

    $('input:checkbox.ChkSkills').each(function (i) {
        if ($(this).is(":checked")) {
            listofSkillsObject = { 'text': ' ', 'value': ' ' };
            //getting current node elements
            currentnode = $(this).val();
            listofSkillsObject.text = currentnode;
            listofSkillsObject.value = currentnode;
            console.log(listofSkillsObject);
            listOfSkill.push(listofSkillsObject);
            var id = $(this).data('skillid');
            if (lstSkillIDs == "") {
                lstSkillIDs = id;
            }
            else {
                lstSkillIDs = lstSkillIDs + "," + id;
            }
        }
    });
        $('#SkillIDs').val(lstSkillIDs);
      $('#skill-tag').tagsinput('removeAll');
      $("#skill-tag").tagsinput("refresh");
      for(i = 0 ; i < listOfSkill.length ; i++){
        $("#skill-tag").tagsinput('add', listOfSkill[i]);
      }
      $("#skill-tag").next().children('input').attr("placeholder", " ");
}
//Adding input tag from dropdown
$('#skill-tag').on('itemAdded', function(event) {
   var lengthInputTag = $("#skill-tag").next().children().length;
    if (lengthInputTag == 1){
        $("#skill-tag").next().children('input').attr("placeholder", "Add Skills");   
    } else if (lengthInputTag > 1){
      $("#skill-tag").next().children('input').attr("placeholder", " ");
    }
  // event.item: contains the item
});

/* On Removing tags */
$('#skill-tag').on('itemRemoved', function(event) {
  var lengthInputTag = $("#skill-tag").next().children().length;
  if (lengthInputTag == 1){
      $("#skill-tag").next().children('input').attr("placeholder", "Add Skills");   
  } 
});

function updateValueSkillText(){
  
  $("#skill-tag").tagsinput("refresh");
  var tagsValue = $("#skill-tag").val();
  var tagsList = tagsValue.split(",");
  for( i=1 ; i <= 27 ; i++){
        $("#skill" + i + "").prop("checked", false);
  }
  for( i=1 ; i <= 27 ; i++){
    for( j = 0 ; j < tagsList.length ; j++ ){
      if($("#skill" + i + "").val() === tagsList[j]){
        $("#skill" + i + "").prop("checked", true);
      }
    }
  }
}

var diploma_set = [{'value':'First Aid Diploma','text':'First Aid Diploma'}, {'value':'Football Referee License','text':'Football Referee License'}, {'value':'Active Volunteering','text':'Active Volunteering'}, {'value':'Training and Assessmement','text':'Training and Assessmement'}, 
                  {'value':'Program Coordination','text':'Program Coordination'}, {'value':'Community Service Coordination','text':'Community Service Coordination'}, {'value':'Effective Communication','text':'Effective Communication'} , {'value':'Negotiation','text':'Negotiation'}, 
                  {'value':'Customer Service','text':'Customer Service'}, {'value':'Risk Management','text':'Risk Management'}]

$('#diploma-tag').tagsinput({
  itemValue: 'value',
  itemText: 'text',
  typeahead: {
    source: diploma_set,
    sorter: function (items) {
        return items.sort();
    }
  }
});

/*Adding method to prevent enter from being click*/
$("#diploma-tag").next().children('input').attr("onkeypress", "doNothing()");

function updateValueDiplomaCheck(){
    var listOfDiploma = [], listofDiplomaObject = {};
    var lstDiplomaIDs = "";
      $('input:checkbox.ChkDiploma').each(function (i) {
          if ($(this).is(":checked")) {
              listofDiplomaObject = { 'text': ' ', 'value': ' ' };
              //getting current node elements
              currentnode = $(this).val();
              listofDiplomaObject.text = currentnode;
              listofDiplomaObject.value = currentnode;
              listOfDiploma.push(listofDiplomaObject);
              var id = $(this).data('diplomaid');
              if (lstDiplomaIDs == "") {
                  lstDiplomaIDs = id;
              }
              else {
                  lstDiplomaIDs = lstDiplomaIDs + "," + id;
              }
          }
      });
      $('#DiplomaIDs').val(lstDiplomaIDs);
  $('#diploma-tag').tagsinput('removeAll');
  $("#diploma-tag").tagsinput("refresh");
  for(i = 0 ; i < listOfDiploma.length ; i++){
    $("#diploma-tag").tagsinput('add', listOfDiploma[i]);
  }
  $("#diploma-tag").next().children('input').attr("placeholder", " ");
}

//Adding input tag from dropdown
$('#diploma-tag').on('itemAdded', function(event) {
   var lengthInputTag = $("#diploma-tag").next().children().length;
    if (lengthInputTag == 1){
        $("#diploma-tag").next().children('input').attr("placeholder", "Add diploma/certificate");   
    } else if (lengthInputTag > 1){
      $("#diploma-tag").next().children('input').attr("placeholder", " ");
    }
  // event.item: contains the item
});

/* On Removing tags */
$('#diploma-tag').on('itemRemoved', function(event) {
  var lengthInputTag = $("#diploma-tag").next().children().length;
  if (lengthInputTag == 1){
      $("#diploma-tag").next().children('input').attr("placeholder", "Add diploma/certificate");   
  }
});

function updateValueDiplomaText(){
  $("#diploma-tag").tagsinput("refresh");
  var tagsValue = $("#diploma-tag").val();
  var tagsList = tagsValue.split(",");
  console.log(tagsList);
  for( i=1 ; i <= 10 ; i++){
        $("#diploma" + i + "").prop("checked", false);
  }
  for( i=1 ; i <= 10 ; i++){
    for( j = 0 ; j < tagsList.length ; j++ ){
      if($("#diploma" + i + "").val() === tagsList[j]){
        $("#diploma" + i + "").prop("checked", true);
      }
    }
  }
}
/*
var source_question = ['Have you taken any Volunteer tests and done well on them that you think are relevant to this job?',
    'Why did you apply to this particular job?',
    'Which part of the project do you think will take the most time?',
    'Do you have any questions about the job description?',
    'Do you have any suggestions to make this project run successfully?',
    'Why do you think you are a good fit for this particular project?',
    'What challenging part of this job are you most experienced in?',
    'Which of the required job skills do you feel you you are strongest at?',
    'What questions do you have about the project?',
    'What past project or job have you had that is most like this one and why?'
];
*/
var listOfScreening = [];
function updateValueScreeningCheck(){  //remove hardcode
    var tempList = listOfScreening;

    $('input:checkbox.ChkQuestions').each(function (i) {
        if ($(this).is(":checked")) {
            debugger;
            var id = $(this).val();
            var question = $(this).data('question');
            addNewTextScreening(id, question);
           
        }
    });
}



function PrepareQuestionsJSON() {
    debugger;
    var rowName = "QuestionId";
    var rowName2 = "QuestionName";
    var tableObject = $('input[name^=qBox]').map(function (i) {
        var row = {};
        row[rowName] = $(this).data('questionid');
        row[rowName2] = $(this).val();
        return row;
    }).get();
    var strJson = JSON.stringify(tableObject);
    if (strJson == "[]") strJson = "";
    return strJson;
}


function addNewTextScreening(qID,question){
    var element_text_screeining = "<div class='col-sm-12' style='padding:0px' id='divTextTag' name='" + "divQuestion" + qID + "'>" +
                                  "<div class='col-sm-9 crossTextbox' style='padding:10px 20px 10px 0px;width:701px; margin-left:93px;'>" +
                                    "<input type='text' class='form-control' id='screening-tag' data-questionid='" + qID + "' placeholder='Add Questions' name='qBox' class='QuestionBox'/>" +
                                    "<button type='button' class='close pull-left screening-Q' aria-hidden='true' onclick='closeTextScreening()' >&times;</button>" +
                                  "</div>" + 
                                "</div>";
    $("div#screening-questions").append(element_text_screeining);
    $("div[name='divQuestion" + qID + "']").find("input").val(question);

}

function closeTextScreening(){ // update the js here
  $(".screening-Q").click(function(){
    remove = $(this).closest("#divTextTag").remove();
  });
}

//$("#screening-tag").attr("onkeypress", "doNothing()");

function updateValueScreeningText() {
  for( i=0 ; i <= 10 ; i++){
    $("#screening" + i + "").prop("checked", false);
  }
  var tagsValues = [];
  var tagsValueScreening = $("#divTextTag:nth-child("+ (0)+")").find("input").val();
  for (var i = 0; tagsValueScreening != undefined ; i++) {
    var tagsValueScreening = $("#divTextTag:nth-child("+ (i + 1)+")").find("input").val();
    tagsValues.push(tagsValueScreening);
  }
  console.log(tagsValues);
    /*
  for (var i = 0; i < source_question.length; i++) {
    for (var j = 0; j < tagsValues.length; j++) {
      if(tagsValues[j] === source_question[i]){
        $("#screening" + (i+1) + "").prop("checked", true);    
      }
    };
  };
    */
  for (var i = 0; i<20 ; i++) {
    var tagsValueScreening = $("#divTextTag:nth-child("+ (i + 1)+")").find("input").val();
    if(tagsValueScreening === ""){
        $("div#screening-questions #divTextTag:nth-child("+ (i + 1)+")").remove();
        console.log("remobe");
    }
  }
};

var volunteer_work_set = ['Answering Telephones', 'Accounting', 'Administration', 'Business Correspondence', 'Client Relations', 'Communication',
                  'Crowd Control', 'Crime & Safety', 'Customer Service', 'Clerical', 'Document Management', 'Disaster Relief', 
                  'Document Management', 'Event Coordination', 'Employee Relations', 'Legal Familiarity', 'Meeting Planning', 'Office Administration',
                  'Organizational Skills', 'Public Relations', 'Public Speaking', 'People Management', 'Receptionist', 'Stenography', 
                  'Travel Arrangements', 'Word Processing', 'Written Communication'];
$('#volunteer-work-tag').tagsinput({
  typeahead: {
    source: volunteer_work_set,
    sorter: function (items) {
        return items.sort();
    }
  }
});

function updateValueVolunteerWork(){
  var listOfVolunteerWork = [];
  for( i=1 ; i <= 27 ; i++){
    if($("#volunteerWork" + i +"").is(":checked")){
     listOfVolunteerWork.push($("#volunteerWork" + i +"").val());
    }
  }
  console.log(listOfSkill);
  $('#volunteer-work-tag').tagsinput('removeAll');
  $("#volunteer-work-tag").tagsinput("refresh");
  for(i = 0 ; i < listOfVolunteerWork.length ; i++){
    $("#volunteer-work-tag").tagsinput('add', listOfVolunteer[i]);
  }
}

function updateValueSkillText(){
  
  $("#skill-tag").tagsinput("refresh");
  var tagsValue = $("#skill-tag").val();
  var tagsList = tagsValue.split(",");
  console.log(tagsList);
  for( i=1 ; i <= 27 ; i++){
        $("#skill" + i + "").prop("checked", false);
  }
  for( i=1 ; i <= 27 ; i++){
    for( j = 0 ; j < tagsList.length ; j++ ){
      if($("#skill" + i + "").val() === tagsList[j]){
        $("#skill" + i + "").prop("checked", true);
      }
    }
  }
}

$(document).ready(function(){
  var completeAddress;
  $('#locationCountry, #locationZip, #locationNumber').on( 'change' , function(){
    var countryLocation = $('#locationCountry').val();
    var zipCodeLocation =  $('#locationZip').val();
    var numberLocation =  $('#locationNumber').val();
    if(zipCodeLocation.length != 0 && numberLocation.length != 0 && countryLocation.length != 0){
        completeAddress = countryLocation + ", " + numberLocation + ", " + zipCodeLocation;
        $('#locationAddress').val(completeAddress);
    }
  });
  
  
});

$('#boxAddress').on('click', '#removeCurrentNode', function(event){
    console.log('in');
    $(this).parent().remove();
    if($('#boxAddress span').length>1){
      $('#boxAddress span a').removeClass('hidden');
      $('#boxAddress span a').addClass('show');
    } else if($('#boxAddress span').length == 1){
      $('#boxAddress span a').removeClass('show');
      $('#boxAddress span a').addClass('hidden');
    }
});


function addressLocationShow(){
  //Element to append
  var completeAddress = $('#locationAddress').val();

  var elementTextbox = "<span class='textBoxCrossIcon margin-top-10'>" + 
                        "<input type='text' class='form-control' value ='" + completeAddress  + "' placeholder='Address'/>" +
                        "<a id='removeCurrentNode'><i class='fa fa-times'></i></a> " +
                        "</span>";
  $('#boxAddress').append(elementTextbox);
  if($('#boxAddress span').length>1){
    $('#boxAddress span a').removeClass('hidden');
    $('#boxAddress span a').addClass('show');
  } else if($('#boxAddress span').length == 1){
    $('#boxAddress span a').removeClass('show');
    $('#boxAddress span a').addClass('hidden');
  }
}

//Stop enter from being execute.
function doNothing() {
   var e = window.event;
   var keyCode = e.keyCode ? e.keyCode : e.which ? e.which : e.charCode;
    if( keyCode == 13 ) {
        e.cancelBubble = true;
        e.returnValue = false;

      if (e.stopPropagation) {
        e.stopPropagation();
        e.preventDefault();
      }
    }
}

