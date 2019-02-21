using System.Collections.Generic;

namespace CDs.Models
{
  public class TrackClass
  {
    private string _artist;
    private string _album;

    public TrackClass(string artist, string album)
    {
      _artist = artist;
      _album = album;
    }

    public string GetArtist()
    {
      return _artist;
    }

    public void SetArtist(string newArtist)
    {
      _artist = newArtist;
    }

    public string GetAlbum()
    {
      return _album;
    }

    public void SetAlbum(string newAlbum)
    {
      _album = newAlbum;
    }
  }
}
