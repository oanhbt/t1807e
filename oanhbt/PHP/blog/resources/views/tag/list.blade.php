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


<a href="tag/create" class="btn btn-info my-3">New Tag</a>

<table class="table">
  <tr>
    <th>No</th>
    <th>Name</th>
    <th>View</th>
    <th>Edit</th>
    <th>Delete</th>
  </tr>
@foreach($lsTag as $i => $tag)
  <tr>
    <td>{{$i + 1}}</td>
    <td>{{$tag->name}}</td>
    <td><a href="{{route('tag.show', $tag->id)}}">View</a></td>
    <td><a href="{{route('tag.edit', $tag->id)}}">update</a></td>
    <td>
      <form action="{{route('tag.destroy', $tag->id)}}" method="POST"
        onsubmit="return confirm('Sure ?')">
        @csrf
        <input type="hidden" name="_method" value="DELETE" />
        <input type="submit" value="Delete" />
      </form>
    </td>
  </tr>
@endforeach
</table>
@endsection
