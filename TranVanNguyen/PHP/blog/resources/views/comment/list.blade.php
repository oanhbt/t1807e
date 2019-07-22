@extends('layouts.app')

@section('content')
<h2>Tag managements</h2>

<!--
@if(session('success')	)
	<div class="alert alert-success">
		{{session('success')}}
	</div>
@endif
-->

@foreach(['success', 'danger'] as $msg)
	@if(session($msg)	)
		<div class="alert alert-{{$msg}}">
			{{session($msg)}}
		</div>
	@endif
@endforeach


{{-- <a href="tag/create" class="btn btn-info my-3">New Tag</a> --}}

<table class="table">
  <tr>
    <th>No</th>
    <th>Username</th>
    <th>Content</th>
    <th>Status</th>
    <th>Change Status</th>
  </tr>
@foreach($lsComment as $i => $comment)
  <tr>
    <td>{{$i + 1}}</td>
    <td>{{$comment->name}}</td>
    <td>{{$comment->content}}</td>
    <td><label id="c_s_{{$comment->id}}">{{$comment -> status == 1? "Show":"Hide"}}</label></td>
    <td>
      <button type="button" 
              class="btn btn-primary" 
              data-toggle="modal" 
              data-target="#exampleModal" 
              data-whatever="{{$comment->id}}">Change Status</button>
    </td>
  </tr>
@endforeach
</table>


<div class="modal fade" id="exampleModal" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel" aria-hidden="true">
  <div class="modal-dialog" role="document">
    <div class="modal-content">
      <div class="modal-header">
        <h5 class="modal-title" id="exampleModalLabel">Change Status</h5>
        <button type="button" class="close" data-dismiss="modal" aria-label="Close">
          <span aria-hidden="true">&times;</span>
        </button>
      </div>
      <div class="modal-body">
        <form>
          @csrf
          <input type="hidden" name="comment_id" id="comment_id">
          <div class="form-group">
            <label for="comment_status" class="col-form-label">Status:</label>
            <select name="comment_status" id="comment_status">
              <option value="1">Show</option>
              <option value="0">Hide</option>
            </select>
          </div>
        </form>
      </div>
      <div class="modal-footer">
        <button type="button" class="btn btn-secondary" data-dismiss="modal">Close</button>
        <button type="button" id="btn_chg_status" class="btn btn-primary">Change</button>
      </div>
    </div> 
  </div>
</div>
<script>
  $('#exampleModal').on('show.bs.modal', function (event) {
    var button = $(event.relatedTarget) // Button that triggered the modal
    var comment_id = button.data('whatever') // Extract info from data-* attributes
    // If necessary, you could initiate an AJAX request here (and then do the updating in a callback).
    // Update the modal's content. We'll use jQuery here, but you could use a data binding library or other methods instead.
    var modal = $(this)
    //modal.find('.modal-title').text('New message to ' + recipient)
    modal.find('.modal-body input#comment_id').val(comment_id)
  });
  $("#btn_chg_status").click(function(e){
    e.preventDefault();
    var comment_id = $("#comment_id").val();
    var _token = $("input[name=_token]").val();
    var comment_status = $("#comment_status").val();
    $.ajax({
      type:'POST',
      url:"{{asset('/change_comment_status_ajax')}}",
      data:{comment_id:comment_id, comment_status:comment_status, _token:_token},
      success:function(data){
        alert("Changed!");
        if(comment_status == 1){
          $("#c_s_" + comment_id).html("Show");
        }else{
          $("#c_s_" + comment_id).html("Hide");
        }
      }
    })
  });


</script>

@endsection
