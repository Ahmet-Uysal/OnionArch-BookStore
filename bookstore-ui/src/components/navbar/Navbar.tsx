// import { AppBar, Box, Button, IconButton, styled, Toolbar, Typography } from '@mui/material'
// import MenuIcon from '@mui/icons-material/Menu';
// import React from 'react'
// import { Link, NavLink, Route, Routes } from 'react-router-dom';
// import App from '../../App';
// import Categories from '../../pages/Categories';
// import ListItemLink from './ListItemLink';

// function Navbar() {
//     const StyledLink = styled(Link)`
//   color: Blue;
//   text-decoration: none;
//   margin: 1rem;
//   position: relative;
// `;
//     return (
//         <Box sx={{ flexGrow: 1 }}>

//             <AppBar position="static" color='secondary'>
//                 <Toolbar>
//                     <IconButton
//                         size="large"
//                         edge="start"
//                         color="inherit"
//                         aria-label="menu"
//                         sx={{ mr: 2 }}
//                     >
//                         <MenuIcon />
//                     </IconButton>
//                     <Typography variant="h6" component="div" sx={{ flexGrow: 1 }}>
//                         News
//                     </Typography>
//                     <Button variant="contained"> Contract <NavLink to="/Contract" ></NavLink></Button>
//                     <Link

//                         <StyledLink to="/Categories" color="inherit">Login</Link>


//                 </Toolbar>
//             </AppBar>
//         </Box>
//     )
// }

// export default Navbar
import * as React from 'react';
import AppBar from '@mui/material/AppBar';
import Box from '@mui/material/Box';
import Toolbar from '@mui/material/Toolbar';
import IconButton from '@mui/material/IconButton';
import Typography from '@mui/material/Typography';
import Menu from '@mui/material/Menu';
import MenuIcon from '@mui/icons-material/Menu';
import Container from '@mui/material/Container';
import Avatar from '@mui/material/Avatar';
import Button from '@mui/material/Button';
import Tooltip from '@mui/material/Tooltip';
import MenuItem from '@mui/material/MenuItem';
import AdbIcon from '@mui/icons-material/Adb';
import { Link } from 'react-router-dom';

const pages = ['Categories', 'Contract'];
const settings = ['Profile', 'Account', 'Dashboard', 'Logout'];

function Navbar() {
    const [anchorElNav, setAnchorElNav] = React.useState<null | HTMLElement>(null);
    const [anchorElUser, setAnchorElUser] = React.useState<null | HTMLElement>(null);

    const handleOpenNavMenu = (event: React.MouseEvent<HTMLElement>) => {
        setAnchorElNav(event.currentTarget);
    };
    const handleOpenUserMenu = (event: React.MouseEvent<HTMLElement>) => {
        setAnchorElUser(event.currentTarget);
    };

    const handleCloseNavMenu = () => {
        setAnchorElNav(null);
    };

    const handleCloseUserMenu = () => {
        setAnchorElUser(null);
    };

    return (
        <AppBar position="static">

            <Container maxWidth="xl">
                <Toolbar disableGutters>
                    <AdbIcon sx={{ display: { xs: 'none', md: 'flex' }, mr: 1 }} />

                    <Box sx={{ flexGrow: 1, display: { xs: 'none', md: 'flex' } }}>
                        {pages.map((page) => (
                            <Button
                                key={page}
                                onClick={handleCloseNavMenu}
                                sx={{ my: 2, color: 'white', display: 'block' }}
                            >
                                <Link style={{ textDecoration: "none", color: "white" }} to={`/${page}`} >{page}</Link>
                            </Button>

                        ))}
                    </Box>
                </Toolbar>
            </Container>
        </AppBar >
    );
}
export default Navbar;