@extends("layouts.app")
@section("content")
<div class="flash-message">
    @foreach (['danger', 'warning', 'success', 'info'] as $msg)        	
      @if(Session::has($msg))
        <p class="alert alert-{{ $msg }}">{{ Session::get($msg) }} </p>
      @endif
    @endforeach
    </div> <!-- end .flash-message -->
  <a href="{{route('post.create')}}">New Post</a>


  <table class="table">
      <tr>
        <th>No</th>
        <th>Title</th>
        <th>View</th>
        <!-- <th>Edit</th> -->
        <th>Status</th>
        <th>Change Status</th>
      </tr>
    @foreach($lsPost as $i => $post)
      <tr>
        <td>{{$i + 1}}</td>
        <td>{{$post->title}}</td>
        <td><a href="{{route('post.show', $post->id)}}">View</a></td>
        <!-- <td><a href="{{route('post.edit', $post->id)}}">Update</a></td> -->
        <td><label id="c_s_{{$post->id}}">{{$post -> status == 1? "Show":"Hide"}}</label></td>
        <td>
          <button type="button" 
                  class="btn btn-primary" 
                  data-toggle="modal" 
                  data-target="#exampleModal" 
                  data-whatever="{{$post->id}}">Change Status</button>
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
          <input type="hidden" name="post_id" id="post_id">
          <div class="form-group">
            <label for="post_status" class="col-form-label">Status:</label>
            <select name="post_status" id="post_status">
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
    var post_id = button.data('whatever') // Extract info from data-* attributes
    // If necessary, you could initiate an AJAX request here (and then do the updating in a callback).
    // Update the modal's content. We'll use jQuery here, but you could use a data binding library or other methods instead.
    var modal = $(this)
    //modal.find('.modal-title').text('New message to ' + recipient)
    modal.find('.modal-body input#post_id').val(post_id)
  });
  $("#btn_chg_status").click(function(e){
    e.preventDefault();
    var post_id = $("#post_id").val();
    var _token = $("input[name=_token]").val();
    var post_status = $("#post_status").val();
    $.ajax({
      type:'POST',
      url:"{{asset('/change_post_status_ajax')}}",
      data:{post_id:post_id, post_status:post_status, _token:_token},
      success:function(data){
        alert("Changed!");
        if(post_status == 1){
          $("#c_s_" + post_id).html("Show");
        }else{
          $("#c_s_" + post_id).html("Hide");
        }
      }
    })
  });


</script>



@endsection
