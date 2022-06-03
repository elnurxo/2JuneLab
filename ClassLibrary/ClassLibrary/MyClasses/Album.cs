using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary.MyClasses
{
    public class Album
    {
        public string Name;
        public string Genre;
        public string Artist;
        private int _trackLimit=10;
        private Track[] _tracks = new Track[0];

        public Track[] Tracks
        {
            get
            {
                return _tracks;
            }
        }


        public void AddTrack(Track track)
        {
            if (_trackLimit> _tracks.Length)
            {
                Array.Resize(ref _tracks, _tracks.Length + 1);
                _tracks[_tracks.Length - 1] = track;
            }
        }

       public Track[] FilterByStream(Album album)
        {
            Track[] FilteredTracks = new Track[0];

            for (int i = 0; i < album.Tracks.Length; i++)
            {
                if (album.Tracks[i].StreamNumber>500000)
                {
                    Array.Resize(ref FilteredTracks, FilteredTracks.Length + 1);
                    FilteredTracks[FilteredTracks.Length - 1] = album.Tracks[i];
                }
            }

            return FilteredTracks;
        }

    }
}
