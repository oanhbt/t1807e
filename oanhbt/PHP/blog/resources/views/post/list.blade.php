@extends("layouts.app")
@section("content")
  <a href="{{route('post.create')}}">New Post</a>

  <table class="table">
    <tr>
      <th>No</th>
      <th>Name</th>
      <th>View</th>
      <th>Edit</th>
      <th>Delete</th>
    </tr>
  @foreach($lsPost as $i => $post)
    <tr>
      <td>{{$i + 1}}</td>
      <td>{{$post->tile}}</td>
      <td><a href="{{route('post.show', $post->id)}}">View</a></td>
      <td><a href="{{route('post.edit', $post->id)}}">update</a></td>
      <td>
        <form action="{{route('post.destroy', $post->id)}}"
  					method="POST"
          	onsubmit="return confirm('Sure ?')">
          	@csrf
          	<input type="hidden" name="_method" value="DELETE" />
          	<input type="submit" value="Delete" />
        </form>
      </td>
    </tr>
  @endforeach

@endsection
