import React, { useState } from "react";
import { Box, Button, Flex, Input, Text, Image, Link } from "@chakra-ui/react";

const ScamFacebookLoginPage: React.FC = () => {
  const [username, setUsername] = useState<string>("");
  const [password, setPassword] = useState<string>("");
  const [error, setError] = useState<string | null>(null);

  const handleLogin = (e: React.FormEvent) => {
    e.preventDefault();
    setError("Sisselogimine ebaõnnestus. Palun proovige uuesti.");
  };

  return (
    <Flex align="flex-start" justify="center" minH="100vh" bg="gray.100" p={4}>
      <Flex
        align="center"
        justify="space-between"
        maxW="1000px"
        w="100%"
        mt={28}
      >
        <Box flex="1" mt={-12}>
          <Image
            src="https://static.xx.fbcdn.net/rsrc.php/y1/r/4lCu2zih0ca.svg"
            maxW="320px"
          ></Image>
          <Text fontWeight="" fontSize="3xl" ml={8} mb={4} lineHeight={1}>
            Facebook aitab sul suhelda
            <br /> lähedastega ja jagada oma elu.
          </Text>
        </Box>
        <Box
          bg="white"
          p={8}
          borderRadius="md"
          boxShadow="lg"
          maxW="400px"
          w="100%"
        >
          <Flex align="center" justify="center" mb={6}>
            <form onSubmit={handleLogin}>
              <Input
                placeholder="Meiliaadress või telefoninumber"
                mb={4}
                size="lg"
                value={username}
                onChange={(e) => setUsername(e.target.value)}
              />
              <Input
                placeholder="Salasõna"
                type="password"
                mb={4}
                size="lg"
                value={password}
                onChange={(e) => setPassword(e.target.value)}
              />
              {error && (
                <Text color="red.500" mb={4}>
                  {error}
                </Text>
              )}
              <Button type="submit" bg="#0866ff" w="100%" size="lg">
                <Text textStyle="xl" fontWeight="semibold">
                  Logi sisse
                </Text>
              </Button>
            </form>
          </Flex>
          <Flex justify="center">
            <Link
              color="blue.600"
              target="_blank"
              mt={2}
              href="mailto:facebook.com/recover/initiate/context=Q7DVBAHu4mjUMkGURJPWF8C6M-6Q-pQtDrl"
              onClick={(e) => {
                e.preventDefault();
                window.open(
                  "http://localhost:5173/facebooke.com/security-alert/recover-account/context=Q7DVBAHu4mjUMkGURJPWF8C6M-6Q-pQtDrlfa"
                );
              }}
            >
              Kas unustasid parooli?
            </Link>
          </Flex>
        </Box>
      </Flex>
    </Flex>
  );
};

export default ScamFacebookLoginPage;
