using System.Collections.Generic;
using CDs.Models;

namespace CDsOrganizer.Models
{
  public class CD
  {
    private string _title;
    private TrackClass _track;

    public CD (string title, TrackClass track)
    {
      _title = title;
      _track = track;
    }

    public string GetTitle()
    {
      return _title;
    }

    public void SetTitle(string newTitle)
    {
      _title = newTitle;
    }

    public string GetTrackArtist()
    {
      return _track.GetArtist();
    }

    public string GetTrackAlbum()
    {
      return _track.GetAlbum();
    }
  }
}
