using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RealClueUML
{
    public class Point
    {
        /// <summary>
        /// Point의 X 좌표
        /// </summary>
        public int X
        {
            get => default(int);
            set
            {
            }
        }

        /// <summary>
        /// Point의 Y 좌표
        /// </summary>
        public int Y
        {
            get => default(int);
            set
            {
            }
        }

        /// <summary>
        /// 움직일 수 있는 좌표를 true로 반환
        /// </summary>
        public bool isMovable
        {
            get => default(int);
            set
            {
            }
        }

        /// <summary>
        /// Equals 함수 재정의
        /// </summary>
        public bool Equals()
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// GetHashCode 함수 재정의
        /// </summary>
        public int GetHashCode()
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// player의 좌표 이동
        /// </summary>
        public Point Move()
        {
            throw new System.NotImplementedException();
        }
    }
}