import './App.css';
import { BrowserRouter, Link, Route, Routes } from 'react-router-dom';
import { Home, Login } from './components/pages';
import { CreateGame, GameDetails, Games } from './components/pages/games';
import { CreateMovie, MovieDetails, Movies } from './components/pages/movies';
import {
    BoardGamesPage,
    BoardGameDetails,
    CreateBoardGame,
} from './components/pages/boardGamesPage';
import AuthContext from './contexts/AuthContext';
import {
    Travelings,
    СreateTravelings,
} from './components/pages/travelings/Index';
import UpdateMovie from './components/pages/movies/UpdateMovie';
import { CreatePost, Post, Posts, UpdatePost } from './components/pages/posts';
import Permission from './contexts/Permission';

function App() {
    return (
        <div className="App">
            <AuthContext>
                <BrowserRouter>
                    <div>
                        <Link to="/">Home</Link>
                        <Link to="/login">Login</Link>
                        <Link to="/game">Games</Link>
                        <Link to="/boardGame">Board Games</Link>
                        <Link to="/movies">Movies</Link>
                        <Link to="/traveling">Traveling</Link>
                        <Link to="/blog">Blog</Link>
                    </div>
                    <div className="content">
                        <Routes>
                            <Route path="" Component={Home}></Route>
                            <Route path="/login" Component={Login}></Route>
                            <Route path="/game">
                                <Route
                                    path=":id"
                                    Component={GameDetails}
                                ></Route>
                                <Route path="" Component={Games}></Route>
                                <Route
                                    path="create"
                                    Component={CreateGame}
                                ></Route>
                            </Route>

                            <Route path="/boardGame">
                                <Route
                                    path=":id"
                                    Component={BoardGameDetails}
                                ></Route>
                                <Route
                                    path=""
                                    Component={BoardGamesPage}
                                ></Route>
                                <Route
                                    path="create"
                                    Component={CreateBoardGame}
                                ></Route>
                            </Route>

                            <Route path="/movies">
                                <Route path="" Component={Movies}></Route>
                                <Route
                                    path=":id"
                                    Component={MovieDetails}
                                ></Route>
                                <Route
                                    path="create"
                                    Component={CreateMovie}
                                ></Route>
                            </Route>
                            <Route path="/movies/update">
                                <Route
                                    path=":movieId"
                                    Component={UpdateMovie}
                                ></Route>
                            </Route>
                            <Route path="/traveling">
                                <Route path="" Component={Travelings}></Route>
                                <Route
                                    path="create"
                                    Component={СreateTravelings}
                                ></Route>
                            </Route>
                            <Route path="/blog">
                                <Route path="" Component={Posts}></Route>
                                <Route
                                    path="create"
                                    Component={CreatePost}
                                ></Route>
                                <Route path="/blog/update">
                                    <Route path=":postId" Component={UpdatePost}></Route>
                                </Route>
                            </Route>
                        </Routes>
                    </div>
                </BrowserRouter>
            </AuthContext>
        </div>
    );
}

export default App;
